using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Excepciones
{
    public class SinProfesorException:Exception
    {
        #region constructores

        public SinProfesorException()
            :base("No hay profesores que puedan dar esta clase")
        {

        }

        #endregion
    }
}
