using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_40
{
    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }

    class Provincial:Llamada
    {

        #region campos

        protected Franja franjaHoraria;

        #endregion

        #region propiedades

        public override float CostoLlamada
        {
            get => this.CalcularCosto();
        }

        #endregion

        #region constructores

        public Provincial(string origen, string destino, float duracion, Franja miFranja)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Llamada llamada, Franja miFranja)
            :this(llamada.NroOrigen, llamada.NroDestino,llamada.Duracion, miFranja)
        {

        }

        #endregion

        #region metodos

        private float CalcularCosto()
        {
            float retorno = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(this.Duracion * 0.99);
                    break;

                case Franja.Franja_2:
                    retorno = (float)(this.Duracion * 1.25);
                    break;

                case Franja.Franja_3:
                    retorno = (float)(this.Duracion * 0.66);
                    break;
            }

            return retorno;
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

            if (obj != null && obj is Provincial)
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
