using System;

namespace ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Jose",37098117, 100, 10);
            Jugador jugador2 = new Jugador("Tomas", 123456, 1, 100);
            Jugador jugador3 = new Jugador("Jose", 37098117, 100, 10);
            Equipo boca = new Equipo(12,"Boca");

            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador1 != jugador2);
            Console.WriteLine(boca + jugador1);
            Console.WriteLine(boca + jugador1);
            Console.WriteLine(boca + jugador2);
            Console.WriteLine(boca + jugador3);
        }
    }
}
