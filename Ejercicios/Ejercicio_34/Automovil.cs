using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Automovil:VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return base.Mostrar() + retorno.AppendFormat("Cantidad de marchas: {0}\nCantidad de pasajeros: {1}", this.cantidadMarchas, this.cantidadPasajeros).ToString();
        }
    }
}
