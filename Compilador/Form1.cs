﻿using Compilador.AnalisisLexico;
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
                txtConsole.AddLine(linea.obtenerNumeroLinea() + ">> " + linea.obtenerContenido());
            }
            AnalizadorLexico analisador = AnalizadorLexico.crear();
            ComponenteLexico componente = analisador.devolderSiguienteComponente();

            while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.obtenerCategoria()))
            {
                componente = analisador.devolderSiguienteComponente();
            }
            agregarTablas();

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
                txtConsole.AddLine(linea.obtenerNumeroLinea() + ">> " + linea.obtenerContenido());
            }
            AnalizadorLexicoLatino analisador = AnalizadorLexicoLatino.crear();
            ComponenteLexico componente = analisador.devolderSiguienteComponente();

            while (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.obtenerCategoria()))
            {

                componente = analisador.devolderSiguienteComponente();
            }
            agregarTablas();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnText.Checked)
            {
                groupBox2.Show();
                groupBox1.Hide();
                groupBox3.Hide();
            }
            else if (rbtnFile.Checked)
            {
                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
            }
            else if (ListaComponente.Checked)
            {
                groupBox3.Show();
                groupBox1.Hide();
                groupBox2.Hide();
                
            }
        }

        private void txtLines_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rbtnFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnText.Checked)
            {
                groupBox2.Show();
                groupBox1.Hide();
                groupBox3.Hide();
            }
            else if (rbtnFile.Checked)
            {
                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
            }
            else if (ListaComponente.Checked)
            {
                groupBox3.Show();
                groupBox1.Hide();
                groupBox2.Hide();

            }
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
            dataGridView1.DataSource = dummyData;
            var literalData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.LITERAL)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria = r.obtenerCategoria(),
                    lexema = r.obtenerLexema()
                }).ToList();
            dataGridView2.DataSource = literalData;
            var reservadaData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.PALABRA_RESERVADA)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria = r.obtenerCategoria(),
                    lexema = r.obtenerLexema()
                }).ToList();
            dataGridView3.DataSource = reservadaData;
            var simboloData = tabla.ObtenerComponentes(Trasnversal.TipoComponente.SIMBOLO)
                .Select(r => new
                {
                    numeroLinea = r.obtenerNumeroLinea().ToString(),
                    posicionInicial = r.obtenerPosicionInicial().ToString(),
                    posicionFinal = r.obtenerPosicionFinal().ToString(),
                    categoria = r.obtenerCategoria(),
                    lexema = r.obtenerLexema()
                }).ToList();
            dataGridView4.DataSource = simboloData;
        }

        private void ListaComponente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnText.Checked)
            {
                groupBox2.Show();
                groupBox1.Hide();
                groupBox3.Hide();
            }
            else if (rbtnFile.Checked)
            {
                groupBox1.Show();
                groupBox2.Hide();
                groupBox3.Hide();
            }
            else if (ListaComponente.Checked)
            {
                groupBox3.Show();
                groupBox1.Hide();
                groupBox2.Hide();

            }
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
