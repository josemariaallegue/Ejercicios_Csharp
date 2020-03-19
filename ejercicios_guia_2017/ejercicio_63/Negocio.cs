using System;
using System.Collections.Generic;
using System.Threading;

namespace ejercicio_63
{
    public class Negocio
    {
        #region atributos

        public Caja Caja1 { get; private set; }
        public Caja Caja2 { get; private set; }
        public List<string> Clientes { get; set; }

        #endregion

        #region constructores

        public Negocio(Caja caja1, Caja caja2)
        {
            Caja1 = caja1;
            Caja2 = caja2;
            Clientes = new List<string>();
        }

        #endregion

        #region metodos

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");

            foreach(string cliente in Clientes)
            {
                if (Caja1.FilaClientes.Count>= Caja2.FilaClientes.Count)
                {
                    Caja2.FilaClientes.Add(cliente);
                }
                else
                {
                    Caja1.FilaClientes.Add(cliente);
                }
            }
        }

        #endregion
    }
}
