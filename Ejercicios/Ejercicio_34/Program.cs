using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº 34";

            Automovil auto = new Automovil(4, 4, VehiculoTerrestre.Colores.Azul, 5, 5);
            Camion camion = new Camion(8, 2, VehiculoTerrestre.Colores.Negro, 16, 1000000);
            Moto moto = new Moto(2, 0, VehiculoTerrestre.Colores.Rojo, 500);

            Console.WriteLine("Autos\n{0}\n\n",auto.Mostrar());
            Console.WriteLine("Camiones\n{0}\n\n", camion.Mostrar());
            Console.WriteLine("Motos\n{0}\n\n", moto.Mostrar());
            Console.ReadKey();
        }
    }
}
