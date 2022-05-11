using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.Error
{
    public class ComponenteError
    {
        public int numeroLinea;
        private int posicionFinal;
        private int posicionInicial;
        private string causa;
        private string falla;
        private string solucion;
        private TipoError tipo;

        private ComponenteError(int numeroLinea, int posicionInicial, int posicionFinal, string causa, string falla, string solucion, TipoError tipo)
        {
            this.numeroLinea = numeroLinea;
            this.posicionFinal = posicionFinal;
            this.posicionInicial = posicionInicial;
            this.causa = causa;
            this.falla = falla;
            this.solucion = solucion;
            this.tipo = tipo;
        }
        public static ComponenteError crearErrorLexico(int numeroLinea, int posicionInicial, int posicionFinal, string causa, string falla, string solucion)
        {
            return new ComponenteError(numeroLinea, posicionInicial, posicionFinal, causa, falla,solucion, TipoError.LEXICO);
        }
        public static ComponenteError crearErrorSintactico(int numeroLinea, int posicionInicial, int posicionFinal, string causa, string falla, string solucion)
        {
            return new ComponenteError(numeroLinea, posicionInicial, posicionFinal, causa, falla, solucion, TipoError.SINTACTICO);
        }
        public static ComponenteError crearErrorSemantico(int numeroLinea, int posicionInicial, int posicionFinal, string causa, string falla, string solucion)
        {
            return new ComponenteError(numeroLinea, posicionInicial, posicionFinal, causa, falla, solucion, TipoError.SEMANTICO);
        }

        public int obtenerNumeroLinea()
        {
            return numeroLinea;
        }

        public int obtenerPosicionInicial()
        {
            return posicionInicial;

        }
        public int obtenerPosicionFinal()
        {
            return posicionFinal;

        }
        public string obtenerCausa()
        {
            return causa;
        }

        public string obtenerFalla()
        {
            return falla;

        }
        public string obtenerSolucion()
        {
            return solucion;

        }
        public TipoError obtenerTipo()
        {
            return tipo;

        }
    }
}
