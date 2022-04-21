using CompiladorClase.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.TablaComponentes
{
    class TablaPalabrasReservadas : TablaMaestra
    {

        private static TablaPalabrasReservadas INSTANCIA = new TablaPalabrasReservadas();
        private static Dictionary<string, ComponenteLexico> TABLA_PALABRAS = new Dictionary<string, ComponenteLexico>();
        private TablaPalabrasReservadas()
        {
            AsignarTipo(Trasnversal.TipoComponente.PALABRA_RESERVADA);
        }

        private void inicializar()
        {
            TABLA_PALABRAS.Add("funcion",ComponenteLexico.crearPalabraReservada("PALABRA_RESERVADA_FUNCION","funcion"));
            TABLA_PALABRAS.Add(".....", ComponenteLexico.crearPalabraReservada("SIMBOLO_5", "....."));
        }

        public static TablaPalabrasReservadas obtenerTabla()
        {
            return INSTANCIA;
        }

        private void comprobarPalabraReservada(ComponenteLexico componente)
        {
            if (componente != null && TABLA_PALABRAS.ContainsKey(componente.obtenerLexema()))
            {
                componente = ComponenteLexico.crearPalabraReservada(componente.obtenerNumeroLinea(),componente.obtenerPosicionInicial(),
                    componente.obtenerPosicionFinal(),TABLA_PALABRAS[componente.obtenerLexema()].obtenerCategoria(),componente.obtenerLexema());
            }
        }

        public override void Agregar(ComponenteLexico componente)
        {
            comprobarPalabraReservada(componente);
            base.Agregar(componente);
        }

    }
}
