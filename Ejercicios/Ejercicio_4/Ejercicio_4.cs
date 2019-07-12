using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Ejercicio_4
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            int i, j;
            int contador =0;
            int acumulador = 0;

            while (contador != 4)
            {
                for (i = 6; ; i++)
                {
                    for (j = i-1; j > 0; j--)
                    {
                        if (i % j==0)
                        {
                            acumulador += j;
                        }
                    }

                    if (acumulador == i)
                    {
                        Console.WriteLine("{0}",acumulador);
                        contador += 1;
                        acumulador = 0;
                    }
                    else
                    {
                        acumulador = 0;
                    }
                }

                
            }

            Console.ReadKey();
        }
    }
}
