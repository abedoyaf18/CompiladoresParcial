using Compilador.Trasnversal;
using CompiladorClase.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.TablaComponentes
{
    public class Tabla
    {
        private static Tabla INSTANCIA = new Tabla();

        private Tabla()
        {

        }

        public static Tabla obtenerTabla()
        {
            return INSTANCIA;
        }
        
        public void Agregar(ComponenteLexico componente)
        {
            TablaPalabrasReservadas.obtenerTabla().Agregar(componente);
            TablaSimbolos.obtenerTabla().Agregar(componente);
            TablaDummy.obtenerTabla().Agregar(componente);
            TablaLiterales.obtenerTabla().Agregar(componente);
        }

        public void Reiniciar()
        {
            TablaPalabrasReservadas.obtenerTabla().reiniciar();
            TablaSimbolos.obtenerTabla().reiniciar();
            TablaDummy.obtenerTabla().reiniciar();
            TablaLiterales.obtenerTabla().reiniciar();
        }

        public List<ComponenteLexico> ObtenerComponentes(TipoComponente tipo)
        {
            List<ComponenteLexico> lista = new List<ComponenteLexico>();
            if (TipoComponente.LITERAL.Equals(tipo))
            {
                lista = TablaLiterales.obtenerTabla().obtenerComponentes();
            }
            else if (TipoComponente.PALABRA_RESERVADA.Equals(tipo))
            {
                lista = TablaPalabrasReservadas.obtenerTabla().obtenerComponentes();
            }
            else if (TipoComponente.SIMBOLO.Equals(tipo))
            {
                lista = TablaSimbolos.obtenerTabla().obtenerComponentes();
            }
            else if (TipoComponente.DUMMY.Equals(tipo))
            {
                lista = TablaDummy.obtenerTabla().obtenerComponentes();
            }
            return lista;
        }
    }
}
