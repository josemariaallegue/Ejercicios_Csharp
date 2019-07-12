using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) 
        {

        }

        public long Sumar(long a, long b)
        {
            long retorno = a + b;

            return retorno;
        }

        public string Sumar(string a, string b)
        {
            string retorno = a+b;

            return retorno;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            long retorno = s1.cantidadSumas + s2.cantidadSumas;

            return retorno;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }

        public static explicit operator int(Sumador s1)
        {
            int retorno = s1.cantidadSumas;

            return retorno;
        }
    }
}
