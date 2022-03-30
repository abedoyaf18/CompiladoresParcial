using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.Traductor
{
    class Traductor
    {
        private static Traductor INSTANCIA = new Traductor();
        private Traductor ()
        {

        }
        public static Traductor obtenerTraductor()
        {
            return INSTANCIA;
        }

        public string traducirCadena(String cadena)
        {
            return cadena;

        }
        public string traducirMorse(String cadena)
        {

            return cadena;
        }

    }
}
