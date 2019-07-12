using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";

            int i = 0;
            int numero = 0;
            int maximo=0, minimo=0;
            int acumulador =0;
            int promedio = 0;

            while (i < 5) 
            {
                Console.WriteLine("Ingrese el numero {0}", i+1);
                numero = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + numero;


                if (i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                else if(numero<minimo)
                {
                    minimo = numero;
                }

                i = i + 1;
            }

            promedio = acumulador / 5;

            Console.WriteLine("El promedio es: {0}, el maximo es {1} y el minimo es {2}", promedio, maximo, minimo);
            Console.ReadKey();
        }
    }
}
