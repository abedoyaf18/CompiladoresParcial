using Compilador.Error;
using CompiladorClase.AnalisisLexico;
using CompiladorClase.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Compilador.AnalisisSintactico
{
    internal class AnalizadorSintactico
    {
        private ComponenteLexico componente;
        private AnalizadorLexico analizadorLexico = AnalizadorLexico.crear();
        private Stack<string> pila = new Stack<string>();
        private StringBuilder sb = new StringBuilder();

        private void formarEntrada(int numeroLlando, string nombreRegla)
        {
            for (int indice = 1; indice <= numeroLlando; indice++)
            {
                sb.Append("....");
            }
            sb.Append("INICIO->");
            sb.Append(nombreRegla);
            sb.Append("->Componente(").Append(componente.obtenerLexema()).Append(",").Append(componente.obtenerCategoria()).Append(")");
            sb.Append("\n");
        }
        private void formarSalida(int numeroLlando, string nombreRegla)
        {
            for (int indice = 1; indice <= numeroLlando; indice++)
            {
                sb.Append("....");
            }
            sb.Append("FIN->");
            sb.Append(nombreRegla);
            sb.Append("\n");
        }

        public string analizar()
        {
            pedirComponente();
            codigo(0);

            if (ManejadorError.obtenerManejadorError().hayErrores())
            {
                MessageBox.Show("Hay errores de compilacion. Por favor verifique los reportes de error respectivos!!!");
            }

            else if (CategoriaGramatical.FIN_ARCHIVO.Equals(componente.obtenerCategoria().ToUpper()))
            {
                if (pila.Count == 1)
                {
                    MessageBox.Show("El programa se cuentra bien escrito. el resultado de la traduccion es: " + pila.Pop());
                }
                else if (pila.Count > 1)
                {
                    //MessageBox.Show(pil)
                    MessageBox.Show("Faltaron componentes por evaluar sintacticamente");
                }
                else
                {
                    MessageBox.Show("AUNQUE SE FINALIZO EXITOSAMENTE , NO SE TIENE UN RESULTADO FINAL.");

                }
                //MessageBox.Show("El programa se encuentra bien escrito");
            }
            else
            {
                MessageBox.Show("Faltaron componentes por evaluar sintacticamente");
            }
            return sb.ToString();
        }
        private void pedirComponente()
        {
            componente = analizadorLexico.devolderSiguienteComponente();
        }

        private void codigo(int numeroLlamado)
        {
            formarEntrada(numeroLlamado, "<codigo>");
            if (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.obtenerCategoria()))
            {
                simbolo(numeroLlamado + 1);
                pedirComponente();
                codigo(numeroLlamado + 1);
            }
            formarSalida(numeroLlamado, "</codigo>");
        }

        private void simbolo(int numeroLlamado)
        {
            formarEntrada(numeroLlamado, "<simbolo>");
            if (CategoriaGramatical.LETRA_A.Equals(componente.obtenerCategoria()))
            {
                sb.Append("a");
            }
            else if (CategoriaGramatical.LETRA_B.Equals(componente.obtenerCategoria()))
            {
                sb.Append("b");
            }
            else if (CategoriaGramatical.LETRA_C.Equals(componente.obtenerCategoria()))
            {
                sb.Append("c");
            }
            else if (CategoriaGramatical.LETRA_D.Equals(componente.obtenerCategoria()))
            {
                sb.Append("d");
            }
            else if (CategoriaGramatical.LETRA_E.Equals(componente.obtenerCategoria()))
            {
                sb.Append("e");
            }
            else if (CategoriaGramatical.LETRA_F.Equals(componente.obtenerCategoria()))
            {
                sb.Append("f");
            }
            else if (CategoriaGramatical.LETRA_G.Equals(componente.obtenerCategoria()))
            {
                sb.Append("g");
            }
            else if (CategoriaGramatical.LETRA_H.Equals(componente.obtenerCategoria()))
            {
                sb.Append("h");
            }
            else if (CategoriaGramatical.LETRA_I.Equals(componente.obtenerCategoria()))
            {
                sb.Append("i");
            }
            else if (CategoriaGramatical.LETRA_J.Equals(componente.obtenerCategoria()))
            {
                sb.Append("j");
            }
            else if (CategoriaGramatical.LETRA_K.Equals(componente.obtenerCategoria()))
            {
                sb.Append("k");
            }
            else if (CategoriaGramatical.LETRA_L.Equals(componente.obtenerCategoria()))
            {
                sb.Append("l");
            }
            else if (CategoriaGramatical.LETRA_M.Equals(componente.obtenerCategoria()))
            {
                sb.Append("m");
            }
            else if (CategoriaGramatical.LETRA_N.Equals(componente.obtenerCategoria()))
            {
                sb.Append("n");
            }
            else if (CategoriaGramatical.LETRA_ENHE.Equals(componente.obtenerCategoria()))
            {
                sb.Append("ñ");
            }
            else if (CategoriaGramatical.LETRA_O.Equals(componente.obtenerCategoria()))
            {
                sb.Append("o");
            }
            else if (CategoriaGramatical.LETRA_P.Equals(componente.obtenerCategoria()))
            {
                sb.Append("p");
            }
            else if (CategoriaGramatical.LETRA_Q.Equals(componente.obtenerCategoria()))
            {
                sb.Append("q");
            }
            else if (CategoriaGramatical.LETRA_R.Equals(componente.obtenerCategoria()))
            {
                sb.Append("r");
            }
            else if (CategoriaGramatical.LETRA_S.Equals(componente.obtenerCategoria()))
            {
                sb.Append("s");
            }
            else if (CategoriaGramatical.LETRA_T.Equals(componente.obtenerCategoria()))
            {
                sb.Append("t");
            }
            else if (CategoriaGramatical.LETRA_U.Equals(componente.obtenerCategoria()))
            {
                sb.Append("u");
            }
            else if (CategoriaGramatical.LETRA_V.Equals(componente.obtenerCategoria()))
            {
                sb.Append("v");
            }
            else if (CategoriaGramatical.LETRA_W.Equals(componente.obtenerCategoria()))
            {
                sb.Append("w");
            }
            else if (CategoriaGramatical.LETRA_X.Equals(componente.obtenerCategoria()))
            {
                sb.Append("x");
            }
            else if (CategoriaGramatical.LETRA_Y.Equals(componente.obtenerCategoria()))
            {
                sb.Append("y");
            }
            else if (CategoriaGramatical.LETRA_Z.Equals(componente.obtenerCategoria()))
            {
                sb.Append("z");
            }
            else if (CategoriaGramatical.NUMERO_0.Equals(componente.obtenerCategoria()))
            {
                sb.Append("0");
            }
            else if (CategoriaGramatical.NUMERO_1.Equals(componente.obtenerCategoria()))
            {
                sb.Append("1");
            }
            else if (CategoriaGramatical.NUMERO_2.Equals(componente.obtenerCategoria()))
            {
                sb.Append("2");
            }
            else if (CategoriaGramatical.NUMERO_3.Equals(componente.obtenerCategoria()))
            {
                sb.Append("3");
            }
            else if (CategoriaGramatical.NUMERO_4.Equals(componente.obtenerCategoria()))
            {
                sb.Append("4");
            }
            else if (CategoriaGramatical.NUMERO_5.Equals(componente.obtenerCategoria()))
            {
                sb.Append("5");
            }
            else if (CategoriaGramatical.NUMERO_6.Equals(componente.obtenerCategoria()))
            {
                sb.Append("6");
            }
            else if (CategoriaGramatical.NUMERO_7.Equals(componente.obtenerCategoria()))
            {
                sb.Append("7");
            }
            else if (CategoriaGramatical.NUMERO_8.Equals(componente.obtenerCategoria()))
            {
                sb.Append("8");
            }
            else if (CategoriaGramatical.NUMERO_9.Equals(componente.obtenerCategoria()))
            {
                sb.Append("9");
            }
            else if (CategoriaGramatical.PUNTO.Equals(componente.obtenerCategoria()))
            {
                sb.Append(".");
            }
            else if (CategoriaGramatical.COMA.Equals(componente.obtenerCategoria()))
            {
                sb.Append(",");
            }
            else if (CategoriaGramatical.SIGNO_PEGUNTA_CIERRA.Equals(componente.obtenerCategoria()))
            {
                sb.Append("?");
            }
            else if (CategoriaGramatical.COMILLA_SIMPLE.Equals(componente.obtenerCategoria()))
            {
                sb.Append("'");
            }
            else if (CategoriaGramatical.ADMIRACION_CIERRA.Equals(componente.obtenerCategoria()))
            {
                sb.Append("!");
            }
            else if (CategoriaGramatical.SLASH.Equals(componente.obtenerCategoria()))
            {
                sb.Append("/");
            }
            else if (CategoriaGramatical.PARENTESIS_ABRE.Equals(componente.obtenerCategoria()))
            {
                sb.Append("(");
            }
            else if (CategoriaGramatical.PARENTESIS_CIERRA.Equals(componente.obtenerCategoria()))
            {
                sb.Append(")");
            }
            else if (CategoriaGramatical.AMPERSAN.Equals(componente.obtenerCategoria()))
            {
                sb.Append("&");
            }
            else if (CategoriaGramatical.DOS_PUNTOS.Equals(componente.obtenerCategoria()))
            {
                sb.Append(":");
            }
            else if (CategoriaGramatical.PUNTO_Y_COMA.Equals(componente.obtenerCategoria()))
            {
                sb.Append(";");
            }
            else if (CategoriaGramatical.IGUAL.Equals(componente.obtenerCategoria()))
            {
                sb.Append("=");
            }
            else if (CategoriaGramatical.SUMA.Equals(componente.obtenerCategoria()))
            {
                sb.Append("+");
            }
            else if (CategoriaGramatical.RESTA.Equals(componente.obtenerCategoria()))
            {
                sb.Append("-");
            }
            else if (CategoriaGramatical.GUION_PISO.Equals(componente.obtenerCategoria()))
            {
                sb.Append("_");
            }
            else if (CategoriaGramatical.DOBLE_COMILLA.Equals(componente.obtenerCategoria()))
            {
                sb.Append("\"");
            }
            else if (CategoriaGramatical.SIGNO_PESOS.Equals(componente.obtenerCategoria()))
            {
                sb.Append("$");
            }
            else if (CategoriaGramatical.ARROBA.Equals(componente.obtenerCategoria()))
            {
                sb.Append("@");
            }
            else if (CategoriaGramatical.SIGNO_PEGUNTA_ABRE.Equals(componente.obtenerCategoria()))
            {
                sb.Append("¿");
            }
            else if (CategoriaGramatical.ADMIRACION_ABRE.Equals(componente.obtenerCategoria()))
            {
                sb.Append("¡");
            }
            else if (CategoriaGramatical.LETRA_CON_TILDE_A.Equals(componente.obtenerCategoria()))
            {
                sb.Append("á");
            }
            else if (CategoriaGramatical.LETRA_CON_TILDE_E.Equals(componente.obtenerCategoria()))
            {
                sb.Append("é");
            }
            else if (CategoriaGramatical.LETRA_CON_TILDE_O.Equals(componente.obtenerCategoria()))
            {
                sb.Append("ó");
            }
            else if (CategoriaGramatical.NUMERAL.Equals(componente.obtenerCategoria()))
            {
                sb.Append("#");
            }
            else if (CategoriaGramatical.BLANCO.Equals(componente.obtenerCategoria()))
            {
                sb.Append(' ');
            }
            else
            {

            }
            formarSalida(numeroLlamado, "</simbolo>");
        }
    }
}
