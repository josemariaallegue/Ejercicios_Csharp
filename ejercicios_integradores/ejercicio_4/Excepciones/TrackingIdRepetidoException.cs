using System;

namespace ejercicio_4.Excepciones
{
    public class TrackingIdRepetidoException : Exception
    {
        #region constructores

        public TrackingIdRepetidoException(string mensaje)
            : base(mensaje)
        {

        }

        public TrackingIdRepetidoException(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }

        #endregion
    }
}
