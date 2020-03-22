using System;

namespace delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja.OperacionHabitual(MostrarMensaje, Sumar, MostrarMensaje);
        }

        public static void MostrarMensaje(string texto)
        {
            Console.WriteLine(texto);
        }

        public static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
