using System;

namespace ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador(10);
            Sumador sumador2 = new Sumador(10);

            Console.WriteLine(Convert.ToString((int)sumador1));

        }
    }
}
