using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public abstract class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        protected VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.AppendFormat("Cantidad de ruedas: {0}\nCantidad de puertas: {1}\nColor: {2}\n", this.cantidadRuedas, this.cantidadPuertas, this.color).ToString();
        }
    }
}
