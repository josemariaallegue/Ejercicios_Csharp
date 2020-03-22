using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Excepciones
{
    class NacionalidadInvalidaException:Exception
    {

        #region campos y atributos

        private static string _mensajeBase = "La nacionalidad es invalida.";

        #endregion

        #region constructores

        public NacionalidadInvalidaException()
            : base(_mensajeBase)
        {

        }

        public NacionalidadInvalidaException(string mensaje)
            : base($"{_mensajeBase} {mensaje}")
        {

        }

        #endregion

    }
}
