using System;


namespace ejercicio_1
{
    public class Numero
    {
        private const int minValue = int.MinValue;
        #region campos y propiedades

        private double _valor;

        private string Valor
        {
            set
            {
               _valor =  ValidarNumero(value);
            }
        }
                

        #endregion

        #region constructrores

        public Numero()
        {
            _valor = 0;
        }

        public Numero(double numero)
            :this()
        {
            _valor = numero;
        }

        public Numero(string numero)
        {
            Valor = numero;
        }

        #endregion

        #region metodos

        private double ValidarNumero(string numero)
        {
            double retorno;

            if(!double.TryParse(numero, out retorno))
            {
                retorno = 0;
            }

            return retorno;
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1._valor + numero2._valor;
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1._valor - numero2._valor;
        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1._valor * numero2._valor;
        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            double retorno = 0;

            if(numero2._valor != 0)
            {
                retorno = numero1 / numero2;
            }
            else
            {
                retorno = double.MinValue;
            }

            return retorno;
        }

        public static double BinarioDecimal(string numero)
        {
            return BitConverter.Int64BitsToDouble(Convert.ToInt64(numero));
        }

        public static string DecimalBinario(double numero)
        {
            return Convert.ToString(BitConverter.DoubleToInt64Bits(numero), 2);
        }

        #endregion
    }
}
