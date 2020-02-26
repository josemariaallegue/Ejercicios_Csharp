using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_50
{
    class Serializar<T, V>:IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto leido", typeof(V));
        }
    }
}
