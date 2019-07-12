using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        public enum Puesto
        {
            caja1, caja2
        }
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                numeroActual += 1;
                return numeroActual;
            }
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            bool retorno = true;
            Random random = new Random();

            Thread.Sleep(random.Next(1, 10) * 1000);            

            return retorno;
        }
        

    }
}
