using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.TablaComponentes
{
    class TablaLiterales : TablaMaestra
    {

        private static TablaLiterales INSTANCIA = new TablaLiterales();
        private TablaLiterales()
        {
            AsignarTipo(Trasnversal.TipoComponente.LITERAL);
        }

        public static TablaLiterales obtenerTabla()
        {
            return INSTANCIA;
        }
    }
}
