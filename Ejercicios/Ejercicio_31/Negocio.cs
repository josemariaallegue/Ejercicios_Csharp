using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();

            caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n.clientes.Contains(c))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (!(n == c))
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            
            return retorno;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }

            set
            {
                if (!(this.clientes.Contains(value)))
                {
                    this.clientes.Enqueue(value);
                }
            }            
        }
    }
}
