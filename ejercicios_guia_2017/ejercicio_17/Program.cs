using System;

namespace ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red, 50);

            boligrafo1.Pintar(99, out dibujo);
            Console.WriteLine(dibujo);
            
        }
    }
}
