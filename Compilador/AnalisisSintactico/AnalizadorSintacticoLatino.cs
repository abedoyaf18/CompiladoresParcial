using Compilador.AnalisisLexico;
using Compilador.Error;
using Compilador.TablaComponentes;
using Compilador.Trasnversal;
using CompiladorClase.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Compilador.AnalisisSintactico
{
    internal class AnalizadorSintacticoLatino
    {
        private ComponenteLexico componente;
        private AnalizadorLexicoLatino analizadorLexico = AnalizadorLexicoLatino.crear();
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
            ManejadorError.obtenerManejadorError().reiniciar();
            pedirComponente();
            pila.Push("");
            latino(0);

            if (ManejadorError.obtenerManejadorError().hayErrores() && Tabla.obtenerTabla().ObtenerComponentes(TipoComponente.DUMMY).Count == 0)
            {
                MessageBox.Show("Hay errores de compilacion. Por favor verifique los reportes de error respectivos!!!");
            }

            else if (CategoriaGramatical.FIN_ARCHIVO.Equals(componente.obtenerCategoria().ToUpper()))
            {
                if (pila.Count == 1)
                {
                    if (Tabla.obtenerTabla().ObtenerComponentes(TipoComponente.DUMMY).Count > 0)
                    {
                        MessageBox.Show("El programa cuenta con errores dummy. el resultado de la traduccion es: " + pila.Pop());
                    }
                    else
                    {
                        MessageBox.Show("El programa se encuentra bien escrito. el resultado de la traduccion es: " + pila.Pop());
                    }
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

        private void latino(int numeroLlamado)
        {
            formarEntrada(numeroLlamado, "<latino>");
            if (!CategoriaGramatical.FIN_ARCHIVO.Equals(componente.obtenerCategoria()))
            {
                caracter(numeroLlamado + 1);
                pedirComponente();
                latino(numeroLlamado + 1);
                string derecha = pila.Pop();
                string izquierda = pila.Pop();
                pila.Push(izquierda + " " + derecha);
            }
            formarSalida(numeroLlamado, "</latino>");
        }

        private void caracter(int numeroLlamado)
        {
            formarEntrada(numeroLlamado, "<caracter>");
            if (CategoriaGramatical.LETRA_A.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-");
            }
            else if (CategoriaGramatical.LETRA_B.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-...");
            }
            else if (CategoriaGramatical.LETRA_C.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.-.");
            }
            else if (CategoriaGramatical.LETRA_D.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-..");
            }
            else if (CategoriaGramatical.LETRA_E.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".");
            }
            else if (CategoriaGramatical.LETRA_F.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..-.");
            }
            else if (CategoriaGramatical.LETRA_G.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--.");
            }
            else if (CategoriaGramatical.LETRA_H.Equals(componente.obtenerCategoria()))
            {
                pila.Push("....");
            }
            else if (CategoriaGramatical.LETRA_I.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..");
            }
            else if (CategoriaGramatical.LETRA_J.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".---");
            }
            else if (CategoriaGramatical.LETRA_K.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.-");
            }
            else if (CategoriaGramatical.LETRA_L.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-..");
            }
            else if (CategoriaGramatical.LETRA_M.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--");
            }
            else if (CategoriaGramatical.LETRA_N.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.");
            }
            else if (CategoriaGramatical.LETRA_ENHE.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--.--");
            }
            else if (CategoriaGramatical.LETRA_O.Equals(componente.obtenerCategoria()))
            {
                pila.Push("---");
            }
            else if (CategoriaGramatical.LETRA_P.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".--.");
            }
            else if (CategoriaGramatical.LETRA_Q.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--.-");
            }
            else if (CategoriaGramatical.LETRA_R.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-.");
            }
            else if (CategoriaGramatical.LETRA_S.Equals(componente.obtenerCategoria()))
            {
                pila.Push("...");
            }
            else if (CategoriaGramatical.LETRA_T.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-");
            }
            else if (CategoriaGramatical.LETRA_U.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..-");
            }
            else if (CategoriaGramatical.LETRA_V.Equals(componente.obtenerCategoria()))
            {
                pila.Push("...-");
            }
            else if (CategoriaGramatical.LETRA_W.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".--");
            }
            else if (CategoriaGramatical.LETRA_X.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-..-");
            }
            else if (CategoriaGramatical.LETRA_Y.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.--");
            }
            else if (CategoriaGramatical.LETRA_Z.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--..");
            }
            else if (CategoriaGramatical.NUMERO_0.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-----");
            }
            else if (CategoriaGramatical.NUMERO_1.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".----");
            }
            else if (CategoriaGramatical.NUMERO_2.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..---");
            }
            else if (CategoriaGramatical.NUMERO_3.Equals(componente.obtenerCategoria()))
            {
                pila.Push("...--");
            }
            else if (CategoriaGramatical.NUMERO_4.Equals(componente.obtenerCategoria()))
            {
                pila.Push("....-");
            }
            else if (CategoriaGramatical.NUMERO_5.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".....");
            }
            else if (CategoriaGramatical.NUMERO_6.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-....");
            }
            else if (CategoriaGramatical.NUMERO_7.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--...");
            }
            else if (CategoriaGramatical.NUMERO_8.Equals(componente.obtenerCategoria()))
            {
                pila.Push("---..");
            }
            else if (CategoriaGramatical.NUMERO_9.Equals(componente.obtenerCategoria()))
            {
                pila.Push("----.");
            }
            else if (CategoriaGramatical.PUNTO.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-.-.-");
            }
            else if (CategoriaGramatical.COMA.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--..--");
            }
            else if (CategoriaGramatical.SIGNO_PEGUNTA_CIERRA.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..--..");
            }
            else if (CategoriaGramatical.COMILLA_SIMPLE.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".----.");
            }
            else if (CategoriaGramatical.ADMIRACION_CIERRA.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.-.--");
            }
            else if (CategoriaGramatical.SLASH.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-..-.");
            }
            else if (CategoriaGramatical.PARENTESIS_ABRE.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.--.");
            }
            else if (CategoriaGramatical.PARENTESIS_CIERRA.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.--.-");
            }
            else if (CategoriaGramatical.AMPERSAN.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-...");
            }
            else if (CategoriaGramatical.DOS_PUNTOS.Equals(componente.obtenerCategoria()))
            {
                pila.Push("---...");
            }
            else if (CategoriaGramatical.PUNTO_Y_COMA.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-.-.-.");
            }
            else if (CategoriaGramatical.IGUAL.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-...-");
            }
            else if (CategoriaGramatical.SUMA.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-.-.");
            }
            else if (CategoriaGramatical.RESTA.Equals(componente.obtenerCategoria()))
            {
                pila.Push("-....-");
            }
            else if (CategoriaGramatical.GUION_PISO.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..--.-");
            }
            else if (CategoriaGramatical.DOBLE_COMILLA.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".-..-.");
            }
            else if (CategoriaGramatical.SIGNO_PESOS.Equals(componente.obtenerCategoria()))
            {
                pila.Push("...-..-");
            }
            else if (CategoriaGramatical.ARROBA.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".--.-.");
            }
            else if (CategoriaGramatical.SIGNO_PEGUNTA_ABRE.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..-.-");
            }
            else if (CategoriaGramatical.ADMIRACION_ABRE.Equals(componente.obtenerCategoria()))
            {
                pila.Push("--...-");
            }
            else if (CategoriaGramatical.LETRA_CON_TILDE_A.Equals(componente.obtenerCategoria()))
            {
                pila.Push(".--.-");
            }
            else if (CategoriaGramatical.LETRA_CON_TILDE_E.Equals(componente.obtenerCategoria()))
            {
                pila.Push("..-..");
            }
            else if (CategoriaGramatical.LETRA_CON_TILDE_O.Equals(componente.obtenerCategoria()))
            {
                pila.Push("---.");
            }
            else if (CategoriaGramatical.NUMERAL.Equals(componente.obtenerCategoria()))
            {
                pila.Push("#");
            }
            else if (CategoriaGramatical.BLANCO.Equals(componente.obtenerCategoria()))
            {
                pila.Push("/");
            }
            else
            {

            }
            formarSalida(numeroLlamado, "</caracter>");
        }
    }
}
