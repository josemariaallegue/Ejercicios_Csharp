using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_31
{
    class Negocio
    {
        #region campos

        private PuestoAtencion _caja;
        private Queue<Cliente> _clientes;
        private string nombre;

        #endregion

        #region propiedades

        public Cliente Cliente
        {
            get
            {
                return this._clientes.Dequeue();
            }

            set
            {
                bool retorno = this + value;
            }
        }

        #endregion

        #region constructores

        private Negocio()
        {
            _clientes = new Queue<Cliente>();
            this._caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region sobrecargas

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;

            foreach(Cliente clienteAux in n._clientes)
            {
                if(clienteAux == c)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n==c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            bool flag = true;

            if (n!=c)
            {
                n._clientes.Enqueue(c);
                retorno = true;
            }

            return retorno;

        }

        public static bool operator ~(Negocio n)
        {
            return n._caja.Atender(n.Cliente);
        }

        #endregion
    }
}
