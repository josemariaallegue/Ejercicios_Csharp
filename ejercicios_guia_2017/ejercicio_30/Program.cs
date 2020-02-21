using System;

namespace ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 auto1 = new AutoF1(1, "Ford");
            AutoF1 auto2 = new AutoF1(2, "Ford");
            AutoF1 auto3 = new AutoF1(2, "Ford");
            AutoF1 auto4 = new AutoF1(3, "Chevy");
            Competencia competencia1 = new Competencia(100,103);

            Console.WriteLine(auto1 == auto2);
            Console.WriteLine(auto1 != auto2);
            Console.WriteLine(auto2 == auto3);

            Console.WriteLine(competencia1 + auto1);
            Console.WriteLine(competencia1 + auto2);
            Console.WriteLine(competencia1 + auto3);
            Console.WriteLine(competencia1 + auto4);

            Console.WriteLine(competencia1 - auto3);
            Console.WriteLine(competencia1 - auto4);

        }
    }
}
