using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_47
{
    class Documento
    {
        private int _numero;
        
        public int Numero
        {
            get => this._numero;
            set => this._numero = value;
        }

        public Documento(int numero)
        {
            this.Numero = numero;
        }

    }
}
