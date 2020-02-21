using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno = false;

            if(c == 'S')
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
