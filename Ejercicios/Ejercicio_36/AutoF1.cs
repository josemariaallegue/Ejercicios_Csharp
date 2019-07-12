using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }

            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public string MostrarDatos()
        {
            StringBuilder auxiliarRetorno = new StringBuilder();

            return base.MostrarDatos() + auxiliarRetorno.AppendFormat("\nCaballos de fuerza: {0}", this.CaballosDeFuerza).ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;

            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
