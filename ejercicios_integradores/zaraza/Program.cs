using System;

namespace zaraza
{
    class Program
    {
        static void Main(string[] args)
        {
            Paquete paquete = new Paquete("Maure 1945", "1234");
            paquete.MockCicloDeVida();
        }
    }
}
