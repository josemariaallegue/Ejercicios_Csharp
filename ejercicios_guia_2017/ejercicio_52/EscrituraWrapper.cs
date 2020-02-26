using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_52
{
    class EscrituraWrapper
    {
        #region campos

        public ConsoleColor color;
        public string texto;

        #endregion

        #region constructores

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }

        #endregion
    }
}
