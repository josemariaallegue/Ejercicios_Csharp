using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_31
{
    class Cliente
    {
        #region campos

        private string _nombre;
        private int _numero;

        #endregion

        #region propiedades

        public string Nombre
        {
            get => this._nombre;
            set => this._nombre = value;
        }

        public int Numero
        {
            get => this._numero;
        }

        #endregion

        #region conctructores

        public Cliente(int numero)
        {
            this._numero = numero;
        }

        public Cliente (int numero, string nombre) 
            : this(numero)
        {
            this.Nombre = nombre;
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;

            if(c1.Numero == c2.Numero)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1==c2);
        }

        #endregion
    }
}
