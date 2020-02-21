using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double numero;
            double total = 0;
            double minimo = 0;
            double maximo = 0;

            for (i = 1;i<6; i++)
            {
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToDouble(Console.ReadLine());
                total += numero;

                if(i == 1)
                {
                    minimo = maximo = numero;
                }
                else if(numero > maximo)
                {
                    maximo = numero;
                }
                else if(numero < minimo)
                {
                    minimo = numero;
                }

                Console.Clear();
            }

            Console.WriteLine($"El numero maximo es {maximo}, el numero minimo es {minimo} y el promedio es {total / 5}");
        }
    }
}
