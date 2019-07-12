using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class MotoCross:VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }

            set
            {
                this.cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public string MostrarDatos()
        {
            StringBuilder auxiliarRetorno = new StringBuilder();

            return base.MostrarDatos() + auxiliarRetorno.AppendFormat("\nCilindrada: {0}", this.Cilindrada).ToString();
        }
    }
}
