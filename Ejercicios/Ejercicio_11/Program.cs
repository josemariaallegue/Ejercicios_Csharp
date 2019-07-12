using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº 11";

            string continuar = "";
            bool primerNumero = false;
            bool flag = false;
            int numero = 0;
            int contador = 0;
            int acumulador = 0;
            int max = 0;
            int min =0;
            int maximoPermitido = 100;
            int minimoPermitido = -100;

            do
            {
                Console.Clear();

                Console.Write("Ingrese un numero: ");
                while (flag == false)
                {
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        if ((Validacion.Validar(numero, maximoPermitido, minimoPermitido)))
                        {
                            Console.Write("Ha ingresado un numero fuera del rango permitido. Reingrese: ");

                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        Console.Write("Ha ingresado un valor no permitido. Reingrese: ");
                    }
                }

                flag = false;

                if (primerNumero == false)
                {
                    min = numero;
                    max = numero;
                }
                else if (max < numero)
                {
                    max = numero;
                }
                else if(min > numero)
                {
                    min = numero;
                }

                contador += 1;
                acumulador += numero;

                Console.Write("Desea continuar S/N: ");

                while(flag == false)
                {
                    continuar = Console.ReadLine();
                    if (continuar != "N" && continuar != "n" && continuar != "S" && continuar != "s")
                    {
                        Console.WriteLine("Se ha ingresado un valor no permitido. Reingrese: ");
                        continuar = Console.ReadLine();
                    }
                    else
                    {
                        flag = true;
                    }    
                }

                flag = false;
                
            } while (continuar == "S" || continuar == "s");

            Console.Clear();
            Console.WriteLine("El maximo es {0}, el minimo es {1} y el promedio es {2}", max, min, acumulador / contador);
            Console.ReadKey();
        }
    }
}
