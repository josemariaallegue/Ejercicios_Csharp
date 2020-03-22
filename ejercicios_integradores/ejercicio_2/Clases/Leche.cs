using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    public class Leche : Producto
    {
        #region campos y propiedades
        public enum ETipo
        {
            Entera,
            Descremada
        }

        private ETipo _tipo;

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion

        #region constructores

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
            _tipo = ETipo.Entera;
        }

        public Leche(EMarca marca, string patente, ConsoleColor color, ETipo tipo)
            : this(marca, patente, color)
        {
            _tipo = tipo;
        }

        #endregion

        #region metodos y sobrecargas

        public override sealed string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine();
            retorno.Append("Leche").AppendLine();
            retorno.AppendLine();
            retorno.Append(base.Mostrar());

            return retorno.ToString();
        }

        #endregion
    }
}
