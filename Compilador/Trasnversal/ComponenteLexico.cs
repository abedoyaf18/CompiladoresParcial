using Compilador.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompiladorClase.Trasnversal
{
    public class ComponenteLexico
    {
        public int numeroLinea;
        private int posicionInicial;
        private int posicionFinal;
        private String categoria;
        private String lexema;
        private TipoComponente tipo;

        private ComponenteLexico(int numeroLinea, int posicionInicial, int posicionFinal, string categoria, string lexema, TipoComponente tipoComponente)
        {
            this.numeroLinea = numeroLinea;
            this.posicionFinal = posicionFinal;
            this.posicionInicial = posicionInicial;
            this.categoria = categoria;
            this.tipo = tipoComponente;
            this.lexema = lexema;
        }

        public static ComponenteLexico crearSimbolo(int numeroLinea, int posicionInicial, int posicionFinal, string categoria, string lexema)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, categoria, lexema, TipoComponente.SIMBOLO);
        }
        public static ComponenteLexico crearLiteral(int numeroLinea, int posicionInicial, int posicionFinal, string categoria, string lexema)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, categoria, lexema, TipoComponente.LITERAL);
        }
        public static ComponenteLexico crearPalabraReservada(int numeroLinea, int posicionInicial, int posicionFinal, string categoria, string lexema)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, categoria, lexema, TipoComponente.PALABRA_RESERVADA);
        }
        public static ComponenteLexico crearPalabraReservada(string categoria, string lexema)
        {
            return new ComponenteLexico(0, 0, 0, categoria, lexema, TipoComponente.PALABRA_RESERVADA);
        }
        public static ComponenteLexico crearDummy(int numeroLinea, int posicionInicial, int posicionFinal, string categoria, string lexema)
        {
            return new ComponenteLexico(numeroLinea, posicionInicial, posicionFinal, categoria, lexema, TipoComponente.DUMMY);
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

        public string obtenerCategoria()
        {
            return categoria;
        }

        public string obtenerLexema()
        {
            return lexema;
        }

        public TipoComponente obtenerTipo()
        {
            return tipo;
        }

        

        public String formarComponente()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Categoria: ").Append(categoria).Append("\n");
            sb.Append("Lexema: ").Append(lexema).Append("\n");
            sb.Append("Numero Linea: ").Append(numeroLinea).Append("\n");
            sb.Append("Posicion inicial: ").Append(posicionInicial).Append("\n");
            sb.Append("Posicion final: ").Append(posicionFinal).Append("\n");

            return sb.ToString();
        }

    }
}
