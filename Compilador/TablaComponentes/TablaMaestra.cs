using Compilador.Trasnversal;
using CompiladorClase.Trasnversal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compilador.TablaComponentes
{
    public class TablaMaestra
    {
        private Dictionary<String, List<ComponenteLexico>> Tabla = new Dictionary<string, List<ComponenteLexico>>();
        private TipoComponente tipo;

        protected void AsignarTipo(TipoComponente tipo)
        {
            this.tipo = tipo;
        }
        public virtual void Agregar(ComponenteLexico componente)
        {
            if (componente!=null&&tipo.Equals(componente.obtenerTipo()))
            {
                obtenerComponentes(componente.obtenerLexema()).Add(componente);
            }
        }

        private List<ComponenteLexico> obtenerComponentes(String clave)
        {
            if (!Tabla.ContainsKey(clave))
            {
                Tabla.Add(clave, new List<ComponenteLexico>());
            }
            return Tabla[clave];
        }

        public List<ComponenteLexico> obtenerComponentes()
        {
            List<ComponenteLexico> lista = new List<ComponenteLexico>();
            foreach(List<ComponenteLexico> componentes in Tabla.Values)
            {
                lista.AddRange(componentes);
            }
            return lista;
        }

        public void reiniciar()
        {
            Tabla.Clear();
        }
    }
}
