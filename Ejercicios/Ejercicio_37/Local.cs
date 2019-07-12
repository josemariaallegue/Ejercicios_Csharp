using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Local:LLamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(LLamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return base.Mostrar() + retorno.AppendFormat("Costo: {0}\n", this.CostoLlamada).ToString();
        }

    }
}
