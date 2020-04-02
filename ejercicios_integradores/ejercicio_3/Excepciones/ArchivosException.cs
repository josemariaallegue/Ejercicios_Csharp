using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Excepciones
{
    public class ArchivosException:Exception
    {
        #region constructores

        public ArchivosException(Exception innerException)
            :base("Error en el manejo de archivos", innerException)
        {

        }

        #endregion
    }
}
