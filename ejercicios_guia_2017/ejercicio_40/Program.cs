using System;

namespace ejercicio_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Emprese zaraza");

            Local l1 = new Local(100, "Origen l1", "Destino l1", 2.65f);
            Local l2 = new Local(150, "Origen l2", "Destino l2", 3f);
            Provincial l3 = new Provincial("Origen l3", "Destino l3", 200, Franja.Franja_1);
            Provincial l4 = new Provincial("Origen l4", "Destino l4", 250, Franja.Franja_3);
            Provincial l5 = new Provincial("Origen l4", "Destino l4", 250, Franja.Franja_2);

            c = c + l1;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            c = c + l2;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            c = c + l3;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            c = c + l4;
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

        }
    }
}
