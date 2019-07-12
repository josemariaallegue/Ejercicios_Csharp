using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº 26";

            List<int> lista = new List<int>();
            Queue<int> queue = new Queue<int>();
            Random random = new Random();
            int i = 0, j = 0;
            int numeroAuxiliar;

            for(i=0;i<20;i++)
            {
                while ((numeroAuxiliar = random.Next(-100,100)) == 0)
                {

                }

                lista.Add(numeroAuxiliar);
                queue.Enqueue(numeroAuxiliar);
            }

            //dos formas para ordernar de mayor a menor.
            //primero algo raro que no se que carajo hace (averiguar en internet)
            lista.Sort((a, b) => -1* a.CompareTo(b));

            //en el segundo se ordena de forma normal y luego se usa ".reverse" para dar vuelta la lista
            lista.Sort();
            //lista.Reverse();

            //lista.ForEach(Console.WriteLine);
            foreach(int item in queue)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();

        }
    }
}
