using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Excepciones
{
    public class AlumnoRepetidoException:Exception
    {
        #region constructores

        public AlumnoRepetidoException()
            :base("El alumno ya esta ingresado")
        {

        }

        #endregion
    }
}
