using Compilador.AnalisisLexico;
using Compilador.AnalisisSintactico;
using Compilador.Error;
using Compilador.TablaComponentes;
using CompiladorClase.AnalisisLexico;
using CompiladorClase.Cache;
using CompiladorClase.Trasnversal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

       

        private void procesarTexto()
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();
            cache.inicializar();
            
            if (rbtnText.Checked)
            {
                foreach(String valorLinea in txtLines.Lines)
                {
                    cache.agregarLinea(valorLinea);
                }
                cache.agregarLinea(CategoriaGramatical.FIN_ARCHIVO);
            }
            else if (rbtnFile.Checked)
            {
                if (label1.Text != "")
                {
                    string[] lines;


                    using (StreamReader sr = new StreamReader(label1.Text))
                    {
                        String file = sr.ReadToEnd();
                        lines = file.Split("\r\n");
                    }
                    foreach (String valorLinea in lines)
                    {
                        cache.agregarLinea(valorLinea);
                    }
                    cache.agregarLinea(CategoriaGramatical.FIN_ARCHIVO);
                }
                
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();
            Tabla tabla = Tabla.obtenerTabla();
            tabla.Reiniciar();

            txtConsole.Text = String.Empty;
            procesarTexto();
            foreach (Linea linea in cache.obtenerLineas())
            {
                if (!linea.obtenerContenido().Equals(CategoriaGramatical.FIN_ARCHIVO))
                {
                    txtConsole.AddLine(linea.obtenerNumeroLinea() + ">> " + linea.obtenerContenido());
                }
            }
            try
            {
                AnalizadorSintactico anaSin = new AnalizadorSintactico();
                MessageBox.Show(anaSin.analizar());
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Stopper, no es posible coninuar la ejecución del programa");
            }
            agregarTablas();
            listarErrores();

        }
        private void latinoButton_Click(object sender, EventArgs e)
        {
            Tabla tabla = Tabla.obtenerTabla();
            tabla.Reiniciar();
            ProgramaFuente cache = ProgramaFuente.obtenerProgramaFuente();

            txtConsole.Text = String.Empty;
            procesarTexto();
            foreach (Linea linea in cache.obtenerLineas())
            {
                if (!linea.obtenerContenido().Equals(CategoriaGramatical.FIN_ARCHIVO))
                {
                    txtConsole.AddLine(linea.obtenerNumeroLinea() + ">> " + linea.obtenerContenido());
                }
            }

            try
            {
                AnalizadorSintacticoLatino anaSinLa = new AnalizadorSintacticoLatino();
                MessageBox.Show(anaSinLa.analizar());
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Stopper, no es posible coninuar la ejecución del programa");
            }
            agregarTablas();
            listarErrores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
        }

        private void cerrarVistas()
        {
            groupBox2.Hide();
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cerrarVistas();
            groupBox2.Show();
        }

        private void txtLines_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rbtnFile_CheckedChanged(object sender, EventArgs e)
        {
            cerrarVistas();
            groupBox1.Show();
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarTablas()
        {
            Tabla tabla = Tabla.obtenerTabla();
            var dummyData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.DUMMY)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria=r.obtenerCategoria(),
                    lexema=r.obtenerLexema()
                }).ToList();
            dummydgv.DataSource = dummyData;
            var literalData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.LITERAL)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria = r.obtenerCategoria(),
                    lexema = r.obtenerLexema()
                }).ToList();
            literaldgv.DataSource = literalData;
            var reservadaData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.PALABRA_RESERVADA)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria = r.obtenerCategoria(),
                    lexema = r.obtenerLexema()
                }).ToList();
            reservadadgv.DataSource = reservadaData;
            var simboloData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.SIMBOLO)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria = r.obtenerCategoria(),
                    lexema = r.obtenerLexema()
                }).ToList();
            simbolodgv.DataSource = simboloData;
        }

        private void listarErrores()
        {
            var erroresDGV = ManejadorError.obtenerManejadorError().obtenerErrores()
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    causa = r.obtenerCausa(),
                    falla = r.obtenerFalla(),
                    solucion = r.obtenerSolucion(),
                    tipo = r.obtenerTipo().ToString()
                }).ToList();
            dataGridView5.DataSource = erroresDGV;
        }
        private void ListaComponente_CheckedChanged(object sender, EventArgs e)
        {
            cerrarVistas();
            groupBox3.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnErrores_CheckedChanged(object sender, EventArgs e)
        {
            cerrarVistas();
            groupBox4.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideAllDTV();
            dummydgv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideAllDTV();
            literaldgv.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            hideAllDTV();
            reservadadgv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideAllDTV();
            simbolodgv.Show();
        }

        private void hideAllDTV()
        {
            dummydgv.Hide();
            literaldgv.Hide();
            reservadadgv.Hide();
            simbolodgv.Hide();
        }
    }
    public static class WinFormsExtensions
    {
        public static void AddLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value ;
            else
                source.AppendText("\r\n"+value);
        }
    }
}
