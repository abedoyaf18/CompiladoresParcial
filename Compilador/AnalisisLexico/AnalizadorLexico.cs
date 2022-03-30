using System;
using System.Collections.Generic;
using System.Text;
using CompiladorClase.Cache;
using CompiladorClase.Trasnversal;

namespace CompiladorClase.AnalisisLexico
{
    class AnalizadorLexico
    {
        private int numeroLineaActual;
        private int apuntador;
        private String caracterActual;
        private String contenidoLineaActual;
        private AnalizadorLexico()
        {
            cargarNuevaLinea();
        }

        public static AnalizadorLexico crear()
        {
            return new AnalizadorLexico();
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

        private bool esIgual(String cadena,String cadena2)
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

        private bool esFinArchivo()
        {
            return esIgual(CategoriaGramatical.FIN_ARCHIVO, caracterActual);
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
            if(esLetra()|| esDigito()|| esComa()||esSuma()||esResta()||esParentecisAbre()||esParentecisCierra()|| esDiferente() ||caracterActual.Equals(" ") 
                || caracterActual.Equals("?") || caracterActual.Equals("'") || caracterActual.Equals("&") || caracterActual.Equals(":") || 
                caracterActual.Equals(";") || caracterActual.Equals(" Revisar  '' ") || caracterActual.Equals("$") || caracterActual.Equals("@") ||
                caracterActual.Equals("¿")|| caracterActual.Equals("¡"))
            {
                return true; 
            }
            return false;
            
        }


        public ComponenteLexico devolderSiguienteComponente()
        {
            ComponenteLexico retorno= null;
            int estadoactual = 0;
            string lexema = "";
            bool continuarAnalisis=true;
            while (continuarAnalisis)
            {
                if(estadoactual == 0)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 1;
                        lexema = lexema + caracterActual;
                    }
                    else if (esGuion())
                    {
                        estadoactual = 2;
                        lexema = lexema + caracterActual;
                    }
                    else if(esBlanco())
                    {
                        estadoactual = 0;
                    }
                    else if (esDivision())
                    {
                        lexema = lexema + caracterActual;
                        estadoactual = 130;
                    }
                    else if (esFinLinea())
                    {
                        estadoactual = 131;
                    }
                    else if (esFinArchivo())
                    {
                        estadoactual = 132;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 1)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 16;
                        lexema = lexema + caracterActual;
                    }
                    else if (esGuion())
                    {
                        estadoactual = 3;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 15;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 2)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 5;
                        lexema = lexema + caracterActual;
                    }
                    else if (esGuion())
                    {
                        estadoactual = 20;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 45;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }

                }
                else if (estadoactual == 3)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 27;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 32;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 4;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }

                }
                else if (estadoactual == 4)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.IDENTIFICADOR, lexema);
                }
                else if (estadoactual == 5)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 52;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 6;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 36;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }

                }
                else if (estadoactual == 6)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 50;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 7;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 14;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 7)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 110;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 79;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 8;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 8)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 9)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 10)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 11)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 99;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 12;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 12)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 13)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 10;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }

                }
                else if (estadoactual == 14)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);

                }
                else if (estadoactual == 15)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 16)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 17;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 23;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 26;
                    }
                    else
                    {
                        estadoactual = 1000;
                    } 
                }
                else if (estadoactual == 17)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 70;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 18;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 46;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 18)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 126;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 59;
                        lexema = lexema + caracterActual;
                    }
                   else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 19;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 19)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 20)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 37;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 21;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 35;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 21)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 41;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 55;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 22;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 22)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);

                }
                else if (estadoactual == 23)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 47;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 24;
                        lexema = lexema + caracterActual;
                    }
                   else  if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 44;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 24)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 75;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 77;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 25;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 25)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 26)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 27)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 28;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 39;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 49;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 28)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 68;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 29;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 29)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 30)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 9;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 31)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 32)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 87;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 33;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 43;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 33)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 117;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 13;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 34;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 34)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 35)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);

                }
                else if (estadoactual == 36)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 37)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 65;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 36;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 38;
                    }
                    else
                    {
                        estadoactual = 1000;
                     }
                }
                else if (estadoactual == 38)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 39)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 57;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 40;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 40)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 41)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 61;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 42;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 42)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 43)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 44)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 45)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);

                }
                else if (estadoactual == 46)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 47)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 73;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 120;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 48;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 48)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 49)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 50)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 102;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 51;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 51)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 52)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 53;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 11;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 31;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 53)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 104;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 54;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 54)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 55)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 91;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 81;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 56;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 56)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 57)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 124;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 58;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 58)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 59)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 60;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 60)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 61)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 62;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 62)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 63)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 83;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 64;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 64)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 65)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 66;
                        lexema = lexema + caracterActual;
                    }
                    else if (esPunto())
                    {
                        estadoactual = 85;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 66)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 67;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 67)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 68)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 97;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 69;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 69)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 70)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 94;
                        lexema = lexema + caracterActual;
                    }
                    else if (esGuion())
                    {
                        estadoactual = 71;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 71)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 72;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 72)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 73)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 74;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 74)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 75)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 76;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 76)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 77)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 78;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 78)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 79)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 113;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 80;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 80)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 81)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 128;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 82;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 82)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 83)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 106;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 84;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 84)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 85)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 86;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 86)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 87)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 88;
                        lexema = lexema + caracterActual;
                    }else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 88)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 89;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 112;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 89)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 90;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 90)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 91)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 92;
                        lexema = lexema + caracterActual;
                    } else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 92)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 93;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 93)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 94)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 95;
                        lexema = lexema + caracterActual;
                    }
                    else if (esGuion())
                    {
                        estadoactual = 115;
                        lexema = lexema + caracterActual;
                    } else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 95)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 96;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 96)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 97)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 98;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 98)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 99)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 108;
                        lexema = lexema + caracterActual;
                    }
                    else if (esGuion())
                    {
                        estadoactual = 100;
                        lexema = lexema + caracterActual;
                    } else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 100)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 101;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 101)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 102)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 103;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 103)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 104)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 30;
                        lexema = lexema + caracterActual;
                    }
                    else if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 105;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 105)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 106)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 107;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 107)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 108)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 109;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 109)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 110)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 111;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 111)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 112)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 113)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 114;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 114)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 115)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 116;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 116)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 117)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 118;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 118)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 119;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 119)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 120)
                {
                    leerSiguienteCaracter();
                    if (esPunto())
                    {
                        estadoactual = 121;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 121)
                {
                    leerSiguienteCaracter();
                    if (esGuion())
                    {
                        estadoactual = 122;
                        lexema = lexema + caracterActual;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 122)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 123;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 123)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 124)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 125;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 125)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 126)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 127;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 127)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 128)
                {
                    leerSiguienteCaracter();
                    if (esBlanco() || esDivision() || esFinLinea())
                    {
                        estadoactual = 129;
                    }
                    else
                    {
                        estadoactual = 1000;
                        //Estado de error para caracteres que no existen
                    }
                }
                else if (estadoactual == 129)
                {
                    continuarAnalisis = false;
                    devolverPuntero();
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 130)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.CODIGO, lexema);
                }
                else if (estadoactual == 131)
                {
                    cargarNuevaLinea();
                    estadoactual = 0;
                }
                else if (estadoactual == 132)
                {
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length, apuntador - 1, CategoriaGramatical.FIN_ARCHIVO, lexema);
                }
                else if (estadoactual == 1000)
                {
                    while (true)
                    {
                        leerSiguienteCaracter();
                        if (esDivision() || esBlanco() || esFinLinea()||esFinArchivo())
                        {
                            devolverPuntero();
                            break;
                        }

                        lexema = lexema + caracterActual;
                    }
                    continuarAnalisis = false;
                    retorno = ComponenteLexico.crear(numeroLineaActual, apuntador - lexema.Length-1, apuntador - 1, CategoriaGramatical.NUMERAL, lexema);
                }


            }
            return retorno;
        }
    }
}
