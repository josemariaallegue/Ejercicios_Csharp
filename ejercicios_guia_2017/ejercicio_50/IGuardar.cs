using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_50
{
    interface IGuardar<T,V>
    {
        public bool Guardar(T obj);

        public V Leer();
    }
}
