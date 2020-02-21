using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            if(numero == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else
            {
                Console.WriteLine($"Cuadrado {Math.Pow(numero, 2)}\nCubo  {Math.Pow(numero, 3)}");
            }
        }
    }
}
