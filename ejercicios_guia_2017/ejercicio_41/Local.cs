using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_41
{
    class Local:Llamada
    {

        #region campos

        protected float costo;

        #endregion

        #region propiedades

        public override float CostoLlamada
        {
            get => this.CalcularCosto();
        }

        #endregion

        #region constructores

       public Local(float duracion, string origen, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            :this(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino,costo)
        {

        }

        #endregion

        #region metodos

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }

        protected string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.Mostrar());
            texto.Append($"Costo de la llamada: {this.CostoLlamada}").AppendLine();

            return texto.ToString();

        }

        #endregion

        #region sobrecargas

        public override bool Equals(object obj)
        {
            bool retorno = false;
            
            if(obj != null && obj is Local)
            {
                retorno = true;
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

    }
}
