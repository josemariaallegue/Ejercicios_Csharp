using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    public class Dulce : Producto
    {
        #region campos y propiedades

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion

        #region constructores

        public Dulce(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {

        }

        #endregion

        #region metodos y sobrecargas

        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine();
            retorno.Append("Dulces").AppendLine();
            retorno.AppendLine();
            retorno.Append(base.Mostrar());

            return retorno.ToString();
        }

        #endregion
    }
}
