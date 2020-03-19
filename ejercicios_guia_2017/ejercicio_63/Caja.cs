using System;
using System.Collections.Generic;
using System.Threading;

namespace ejercicio_63
{
    public class Caja
    {
        #region atributos

        public List<string> FilaClientes { get; set; }

        #endregion

        #region constructores

        public Caja()
        {
            FilaClientes = new List<string>();
        } 

        #endregion

        #region metodos

        public void AtenderClientes()
        {
            Random random1 = new Random();

            foreach(string cliente in FilaClientes)
            {
                Thread.Sleep(random1.Next(1000, 4000));
                Console.WriteLine($"Cliente {cliente} en {Thread.CurrentThread.Name}");
            }
        }
        #endregion
    }
}
