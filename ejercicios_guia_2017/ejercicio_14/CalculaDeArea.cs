using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_14
{
    class CalculaDeArea
    {
        public static double CalcularCuadraro(double lado)
        {
            return lado * lado;
        }

        public static double CalcularTriangulo(double piso, double altura)
        {
            return (piso * altura) / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return (Math.PI * Math.Pow(radio, 2));
        }
    }
}
