using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Archivos
{
    public interface IArchivo<T>
    {
        #region metodos
        public bool Guardar(string archivo, T datos);
        public bool Leer(string archivo, out T datos);
        #endregion
    }
}
