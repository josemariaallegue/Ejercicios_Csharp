using System;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            char continuar = ' ';

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDesea agreagar otro numero? S/N");
                continuar = Convert.ToChar(Console.ReadLine());
                
            } while (ValidarRespuesta.ValidaS_N(continuar));
        }
    }
}
