using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_52
{
    interface IAcciones
    {
        #region propieades

        ConsoleColor Color { get; set; }

        float UnidadesDeEscritura { get; set; }

        #endregion

        #region metodos

        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);
        
        #endregion


    }
}
