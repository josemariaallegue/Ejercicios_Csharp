using System;

namespace ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Jose", "Allegue", 123,10,7);
            Alumno alumno2 = new Alumno("Tomas", "Echevarria", 456,4,4);
            Alumno alumno3 = new Alumno("Carlos", "Pestarino", 789,4,2);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
        }
    }
}
