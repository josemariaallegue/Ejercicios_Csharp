using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    class Provincial:LLamada
    {
        #region Atributos
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja _frajaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, LLamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._frajaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._frajaHoraria = miFranja;
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.AppendFormat("{0}\nFranja horaria: {1}\nCosto de la llamada: {2}\n", base.Mostrar(), this._frajaHoraria, this.CostoLlamada).ToString();
        }

        private float CalcularCosto()
        {
            float retorno = 0;

            switch (this._frajaHoraria)
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

                default:
                    retorno = 0;
                    break;
            }

            return retorno;
        }
        #endregion

        #region Sobrecargas
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
