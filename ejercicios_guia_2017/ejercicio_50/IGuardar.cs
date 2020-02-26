using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_50
{
    interface IGuardar<T,V>
    {
         bool Guardar(T obj);

         V Leer();
    }
}
