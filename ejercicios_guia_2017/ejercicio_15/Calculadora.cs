using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double numero1, double numero2, string operador)
        {
            double retorno = 0;

            switch(operador)
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;

                case "-":
                    retorno = numero1 - numero2;
                    break;

                case "*":
                    retorno = numero1 * numero2;
                    break;

                case "/":
                    if(Validar(numero2))
                    {
                        retorno = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Imposible realizar la operacion");
                    }
                    break;
            }

            return retorno;
        }

        private static bool Validar(double numero2)
        {
            return numero2 != 0 ? true : false;

        }

        public static void Mostrar(double resultado)
        {
            Console.WriteLine($"El resultado de la operacion es {resultado}");
        }
    }
}
