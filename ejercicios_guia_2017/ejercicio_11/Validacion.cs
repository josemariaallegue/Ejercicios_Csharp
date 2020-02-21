using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno;

            retorno = valor >= min && valor <= max ? true : false;

            return retorno;
        }
    }
}
