using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compilador.Error
{
    public class ManejadorError
    {
        private Dictionary<TipoError, List<ComponenteError>> errores;
        private static ManejadorError INSTANCIA = new ManejadorError();

        private ManejadorError()
        {
            reiniciar();
        }

        public void reiniciar()
        {
            errores = new Dictionary<TipoError, List<ComponenteError>>();
            errores.Add(TipoError.LEXICO, new List<ComponenteError>());
            errores.Add(TipoError.SINTACTICO, new List<ComponenteError>());
            errores.Add(TipoError.SEMANTICO, new List<ComponenteError>());
        }

        public static ManejadorError obtenerManejadorError()
        {
            return INSTANCIA;
        }

        public void agregar(ComponenteError error)
        {
            if (error != null)
            {
                errores[error.obtenerTipo()].Add(error);
            }
        }

        public bool hayErrores(TipoError tipo)
        {
            return errores[tipo].Count() > 0;
        }

        public bool hayErrores()
        {
            return hayErrores(TipoError.LEXICO) || hayErrores(TipoError.SEMANTICO) || hayErrores(TipoError.SINTACTICO);
        }

        public List<ComponenteError> obtenerErrores()
        {
            List<ComponenteError> lista = new List<ComponenteError>();
            foreach (List<ComponenteError> componentes in errores.Values)
            {
                lista.AddRange(componentes);
            }
            return lista;
        }
    }
}
