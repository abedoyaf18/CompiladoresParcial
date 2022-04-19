using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.TablaComponentes
{
    class TablaDummy : TablaMaestra
    {

        private static TablaDummy INSTANCIA = new TablaDummy();
        private TablaDummy()
        {
            AsignarTipo(Trasnversal.TipoComponente.DUMMY);
        }

        public static TablaDummy obtenerTabla()
        {
            return INSTANCIA;
        }
    }
}
