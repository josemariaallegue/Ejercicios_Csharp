using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return base.Mostrar() + retorno.AppendFormat("Cilindrada: {0}", this.cilindrada).ToString();
        }
    }
}
