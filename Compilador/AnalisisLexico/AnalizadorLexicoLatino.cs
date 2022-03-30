using CompiladorClase.Cache;
using CompiladorClase.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.AnalisisLexico
{
    class AnalizadorLexicoLatino
    {
        private int numeroLineaActual;
        private int apuntador;
        private String caracterActual;
        private String contenidoLineaActual;
        private AnalizadorLexicoLatino()
        {
            cargarNuevaLinea();
        }

        public static AnalizadorLexicoLatino crear()
        {
            return new AnalizadorLexicoLatino();
        }

        private void cargarNuevaLinea()
        {
            numeroLineaActual += 1;
            Linea lineaActual = ProgramaFuente.obtenerProgramaFuente().obtenerLinea(numeroLineaActual);
            contenidoLineaActual = lineaActual.obtenerContenido();
            numeroLineaActual = lineaActual.obtenerNumeroLinea();
            apuntador = 1;
        }

        private void leerSiguienteCaracter()
        {

            if (CategoriaGramatical.FIN_ARCHIVO.Equals(contenidoLineaActual))
            {
                caracterActual = CategoriaGramatical.FIN_ARCHIVO;
            }
            else if (apuntador > contenidoLineaActual.Length)
            {
                caracterActual = CategoriaGramatical.FIN_LINEA;
                apuntador++;
            }
            else
            {
                caracterActual = contenidoLineaActual.Substring(apuntador - 1, 1);
                apuntador++;
            }
        }
        private void devolverPuntero()
        {
            apuntador--;
        }

        private bool esIgual(String cadena, String cadena2)
        {
            if (cadena == null && cadena2 == null)
            {
                return true;
            }
            else if (cadena == null)
            {
                return false;
            }
            return cadena.Equals(cadena2);
        }
        private bool esLetra()
        {
            return Char.IsLetter(caracterActual.ToCharArray()[0]);
        }
        private bool esDigito()
        {
            return Char.IsDigit(caracterActual.ToCharArray()[0]);
        }
        private bool esPesos()
        {
            return "$".Equals(caracterActual);
        }

        private bool esGuionBajo()
        {
            return "_".Equals(caracterActual);
        }

        private bool esFinLinea()
        {
            return esIgual(CategoriaGramatical.FIN_LINEA, caracterActual);
        }
        private bool esComa()
        {
            return ",".Equals(caracterActual);
        }
        private bool esSuma()
        {
            return "+".Equals(caracterActual);
        }
        private bool esResta()
        {
            return "-".Equals(caracterActual);
        }
        private bool esDivision()
        {
            return "/".Equals(caracterActual);
        }
        private bool esParentecisAbre()
        {
            return "(".Equals(caracterActual);
        }
        private bool esParentecisCierra()
        {
            return ")".Equals(caracterActual);
        }
        private bool esIgual()
        {
            return "=".Equals(caracterActual);
        }

        private bool esDiferente()
        {
            return "!".Equals(caracterActual);
        }
        private bool esPunto()
        {
            return ".".Equals(caracterActual);
        }
        private bool esBlanco()
        {
            return " ".Equals(caracterActual);
        }
        private bool esGuion()
        {
            return "-".Equals(caracterActual);
        }

        private bool esCaracter()
        {
            if (esLetra() || esDigito() || esComa() || esSuma() || esResta() || esParentecisAbre() || esParentecisCierra() || esDiferente() || caracterActual.Equals(" ")
                || caracterActual.Equals("?") || caracterActual.Equals("'") || caracterActual.Equals("&") || caracterActual.Equals(":") ||
                caracterActual.Equals(";") || caracterActual.Equals(" Revisar  '' ") || caracterActual.Equals("$") || caracterActual.Equals("@") ||
                caracterActual.Equals("¿") || caracterActual.Equals("¡"))
            {
                return true;
            }
            return false;

        }

        public ComponenteLexico devolderSiguienteComponente()
        {
            ComponenteLexico retorno = null;
            int estadoactual = 0;
            string lexema = "";
            bool continuarAnalisis = true;
            while (continuarAnalisis)
            {
                if (estadoactual == 0)
                {
                    leerSiguienteCaracter();
                    if (esCaracter())
                    {
                        estadoactual = 1;
                        lexema = caracterActual;
                    }
                    else if (esFinLinea())
                    {
                        estadoactual = 3;
                        lexema = caracterActual;
                    }
                    else if (CategoriaGramatical.FIN_ARCHIVO.Equals(caracterActual))
                    {
                        estadoactual = 4;
                    }
                    else
                    {
                        estadoactual = 2;
                    }
                }
                else if (estadoactual == 1)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 2)
                {
                    throw new Exception("Caracter no valido");
                }
                else if (estadoactual == 3)
                {
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.FIN_LINEA, lexema);
                    cargarNuevaLinea();
                    continuarAnalisis = false;

                }
                else if (estadoactual == 4)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.FIN_ARCHIVO, lexema);
                }


            }
            return retorno;

        }


    } 
}
