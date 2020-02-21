using System;

namespace ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string operador = "/";
            double numero1 = 100;
            double numero2 = 0;

            Calculadora.Mostrar(Calculadora.Calcular(numero1, numero2, operador));
        }
    }
}
