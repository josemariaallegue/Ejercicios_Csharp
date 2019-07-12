using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N° 16";

            Alumno alumno1 = new Alumno("Allegue","Jose", 12465,1,10);
            Alumno alumno2 = new Alumno("Orsini","Maria", 54635,5,9);
            Alumno alumno3 = new Alumno("Garnica","Barbara", 67848,8,4);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            alumno1.mostrar();
            alumno2.mostrar();
            alumno3.mostrar();

            Console.ReadKey();
        }
    }
}
