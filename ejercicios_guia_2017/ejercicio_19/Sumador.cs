using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_19
{
    class Sumador
    {
        #region campos

        private int _cantidadSumas;

        #endregion

        #region constructores

        public Sumador() : this(0)
        {

        }

        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas = cantidadSumas;
        }

        #endregion

        #region metodos

        /// <summary>
        /// suma 2 longs
        /// </summary>
        /// <param name="a">valor 1</param>
        /// <param name="b">valor 2</param>
        /// <returns></returns>
        public long Sumar(long a, long b)
        {
            this._cantidadSumas += 1;

            return a + b;
        }

        /// <summary>
        /// concatenad 2 strings
        /// </summary>
        /// <param name="a">string 1</param>
        /// <param name="b">string 2</param>
        /// <returns></returns>
        public string Sumar(string a, string b)
        {
            this._cantidadSumas += 1;
            return a + b;
        }

        #endregion

        #region sobrecargas

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1._cantidadSumas + s2._cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if(s1._cantidadSumas == s2._cantidadSumas)
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion

    }
}
