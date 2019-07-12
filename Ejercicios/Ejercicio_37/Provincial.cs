using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    class Provincial:LLamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja _frajaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, LLamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._frajaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this._frajaHoraria = miFranja;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return base.Mostrar() + retorno.AppendFormat("Franja horaria: {0}\nCosto de la llamada: {1}\n", this._frajaHoraria, this.CostoLlamada).ToString();
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

    }
}
