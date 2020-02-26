using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_41
{
    class CentralitaException:Exception
    {
        #region campos

        private string _nombreClase;
        private string _nombreMetodo;

        #endregion

        #region propiedades

        public Exception ExceptionInterna
        {
            get => base.InnerException;
        }

        public string NombreClase
        {
            get => this._nombreClase;
        }

        public string NombreMetodo
        {
            get => this._nombreMetodo;
        }

        #endregion

        #region constructores

        public CentralitaException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        #endregion
    }
}
