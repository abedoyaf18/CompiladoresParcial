using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.TablaComponentes
{
    public class TablaSimbolos: TablaMaestra
    {

        private static TablaSimbolos INSTANCIA = new TablaSimbolos();
        private TablaSimbolos()
        {
            AsignarTipo(Trasnversal.TipoComponente.SIMBOLO);
        }

        public static TablaSimbolos obtenerTabla()
        {
            return INSTANCIA;
        }
    }
}
