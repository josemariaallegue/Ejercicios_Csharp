using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class LLamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todos
        }
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        public LLamada (float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        public string Mostrar ()
        {
            StringBuilder retorno = new StringBuilder();

            return retorno.AppendFormat("Duracion: {0}\nNro. destino: {1}\nNro. origen: {2}\n", this.Duracion, this.NroDestino, this.NroOrigen).ToString();

        }

        public static int OrdenarPorDuracion(LLamada llamada1, LLamada llamada2)
        {
            int retorno;

            if (llamada1.Duracion == llamada2.Duracion)
            {
                retorno = 0;
            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }

    }
}
