using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class Local:LLamada
    {
        #region Atributos
        protected float _costo;
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
        public Local(LLamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this._costo = costo;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.AppendFormat("{0}\nCosto: {1}\n",base.Mostrar(), this.CostoLlamada).ToString();
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj != null && obj is Local)
            {
                retorno = true;
            }

            return retorno;
        }
        #endregion










    }
}
