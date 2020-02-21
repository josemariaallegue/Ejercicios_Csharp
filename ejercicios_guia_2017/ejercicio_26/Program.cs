using System;
using System.Collections.Generic;

namespace ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random1 = new Random();
            List<int> lista1 = new List<int>();
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();

            for (int i = 0; i<=20; i++)
            {
                lista1.Add(random1.Next(-100,100));
            }

            foreach(int numero in lista1)
            {
                if (numero > 0)
                {
                    listaPositivos.Add(numero);
                }
                else if(numero<0)
                {
                    listaNegativos.Add(numero);
                }
            }

            Console.WriteLine("\nListado de numero positivos");
            listaPositivos.Sort(OrdernarLista);
            foreach(int numero in listaPositivos)
            {
                Console.WriteLine(Convert.ToString(numero));
            }

            Console.WriteLine("\nListado de numero negativos");
            listaNegativos.Sort(OrdernarLista);
            foreach (int numero in listaNegativos)
            {
                Console.WriteLine(Convert.ToString(numero));
            }
        }

        public static int OrdernarLista(int a, int b)
        {
            int retorno = 0;

            if (a > b)
            {
                retorno = -1;
            }
            else if (a < b)
            {
                retorno = 1;
            }

            return retorno;
        }
    }
}
