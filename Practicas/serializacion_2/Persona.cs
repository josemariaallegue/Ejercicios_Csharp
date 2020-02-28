using System;
using System.Collections.Generic;
using System.Text;

namespace serializacion_2
{
    [Serializable]
    class Persona
    {
        #region campos
        public string Nombre { get; set; }
        public int Edad { get; set; }

        #endregion
    }
}
