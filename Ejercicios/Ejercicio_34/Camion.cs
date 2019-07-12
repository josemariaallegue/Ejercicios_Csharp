using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Camion:VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return base.Mostrar() + retorno.AppendFormat("Cantidad de marchas: {0}\nPeso de la carga: {1}", this.cantidadMarchas, this.pesoCarga).ToString();
        }

    }
}
