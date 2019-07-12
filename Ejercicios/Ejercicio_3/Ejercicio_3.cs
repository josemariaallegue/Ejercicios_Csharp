using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Ejercicio_3
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";

            int numero;
            int i, j;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= numero; i++) 
            {
                for (j = 2; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        break;
                    }
                }

                if (j==i) 
                {
                    Console.WriteLine("{0}", i);
                }                    
            }

            Console.ReadKey();
            
        }
    }
}
