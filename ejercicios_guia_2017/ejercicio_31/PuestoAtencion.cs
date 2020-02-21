using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ejercicio_31
{
    public enum Puesto
    {
        Caja1,
        Caja2
    }

    class PuestoAtencion
    {
        #region campos

        private static int _numeroActual;
        private Puesto _puesto;

        #endregion

        #region propiedades

        public int NumeroActual
        {
            get
            {
                _numeroActual += 1;
                return _numeroActual;
            }
        }

        #endregion

        #region constructores

        private PuestoAtencion()
        {
            _numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this._puesto = puesto;
        }

        #endregion

        #region metodos

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(150);

            return true;
        }

        #endregion

    }
}
