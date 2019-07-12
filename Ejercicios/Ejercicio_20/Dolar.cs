using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Dolar
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public float GetCotizacion
        {
            get
            {
                return this.cotizRespectoDolar;
            }
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno = false;

            if (d1.cantidad == d2.cantidad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }     
    }
}
