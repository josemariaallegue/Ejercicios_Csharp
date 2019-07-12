using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";

            double numero = 0;

            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (numero == 0);

            Console.WriteLine("El cuadrado del numero ingresado es {0} y el cubo del numero ingresado es {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
            Console.ReadKey();
        }
    }
}
