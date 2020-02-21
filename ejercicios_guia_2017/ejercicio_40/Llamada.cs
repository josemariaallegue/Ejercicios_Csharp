using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_40
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    abstract class Llamada
    {

        #region campos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region propiedades

        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get => this.duracion;
        }

        public string NroDestino
        {
            get => this.nroDestino;
        }

        public string NroOrigen
        {
            get => this.nroOrigen;
        }

        #endregion

        #region constructores

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        #endregion

        #region metodos

        protected virtual string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append($"Numero origen: {this.NroOrigen}").AppendLine();
            texto.Append($"Numero destino: {this.NroDestino}").AppendLine();
            texto.Append($"Duracion: {this.Duracion}").AppendLine();

            return texto.ToString();
        }

        public int OrdenarLlamada(Llamada l1, Llamada l2)
        {
            int retorno = 0;

            if(l1.Duracion > l2.Duracion)
            {
                retorno = 1;
            }
            else if(l1.Duracion < l2.Duracion)
            {
                retorno = -1;
            }

            return retorno;

        }

        #endregion

        #region sobrecargas

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l2.NroOrigen == l2.NroOrigen)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1==l2);
        }

        #endregion
    }
}
