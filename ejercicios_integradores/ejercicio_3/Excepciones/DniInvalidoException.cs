using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Excepciones
{
    class DniInvalidoException:Exception
    {
        #region campos y propiedades

        private static string _mensajeBase = "El DNI ingresado es invalido.";

        #endregion

        #region constructores

        public DniInvalidoException()
            :base(_mensajeBase)
        {

        }
            
        public DniInvalidoException(string mensaje)
            :base($"{_mensajeBase} {mensaje}")
        {
            
        }

        public DniInvalidoException(Exception e)
            : base(_mensajeBase, e)
        {

        }

        public DniInvalidoException(string mensaje, Exception e)
            :base($"{_mensajeBase} {mensaje}", e)
        {

        }    

        #endregion
    }
}
