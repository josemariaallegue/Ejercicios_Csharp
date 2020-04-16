using System;
using System.IO;

namespace zaraza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paquete paquete = new Paquete("Maure 1945", "1234");
            DirectoryInfo directory = new DirectoryInfo(@"..\..\..\Archivos\salida.txt");
            //paquete.MockCicloDeVida();
            Console.WriteLine(directory.FullName);
        }
    }
}
