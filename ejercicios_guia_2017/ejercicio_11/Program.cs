using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int numero;
            int total = 0;
            int max = 100;
            int min = 0;

            for (i = 1; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToInt32(Console.ReadLine());

                while (!Validacion.Validar(numero, min, max))
                {
                    Console.Clear();
                    Console.WriteLine($"{numero} es mayor a {max} o menor a {min}");
                    Console.WriteLine("Ingrese un nuevo numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                total += numero;
            }

            Console.Clear();
            Console.WriteLine($"Valor minimo permitido {min}\nValor maximo permitido {max}\nPromedio {total / 10}");
        }
    }
}
