using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public abstract class LLamada
    {
        #region Atributos
        public enum TipoLlamada
        {
            Local, Provincial, Todos
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructores
        public LLamada (float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar ()
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
        #endregion

        #region Sobrecargas
        public static bool operator ==(LLamada l1, LLamada l2)
        {
            bool retorno = false;

            if (((Local)l1).Equals(l2) || ((Provincial)l1).Equals(l2))
            {
                if (l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino)
                {
                    retorno = true;
                }
            }               

            return retorno;
        }

        public static bool operator !=(LLamada l1, LLamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
