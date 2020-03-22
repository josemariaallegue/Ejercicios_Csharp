using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    public class Snacks : Producto
    {
        #region campos y propiedades

        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        #endregion

        #region constructores

        public Snacks(EMarca marca, string patente, ConsoleColor color)
           : base(patente, marca, color)
        {

        }

        #endregion

        #region metodos y sobrecargas

        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine();
            retorno.Append("Snacks").AppendLine();
            retorno.AppendLine();
            retorno.Append(base.Mostrar());

            return retorno.ToString();
        }

        #endregion
    }
}
