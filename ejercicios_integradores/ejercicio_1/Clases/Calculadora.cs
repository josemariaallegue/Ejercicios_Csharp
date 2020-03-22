using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    public class Calculadora
    {
        #region metodos

        public double Operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;

            switch (ValidarOperador(operador))
            {
                case "+":
                    retorno = numero1 + numero2;
                    break;

                case "-":
                    retorno = numero1 - numero2;
                    break;

                case "/":
                    retorno = numero1 / numero2;
                    break;

                case "*":
                    retorno = numero1 * numero2;
                    break;
            }

            return retorno;
        }

        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            string[] operadoresPermitidos = { "+", "-", "/", "*" };

            if (operadoresPermitidos.Contains(operador))
            {
                retorno = operador;
            }

            return retorno;
        }

        #endregion
    }
}
