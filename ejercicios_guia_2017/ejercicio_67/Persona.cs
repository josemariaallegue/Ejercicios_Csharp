using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_67
{
    public class Persona
    {
        #region propiedades

        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        #endregion

        #region constructores

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        #endregion

        #region metodos

        public string Mostrar()
        {
            return $"Nombre: {Nombre} Apellido: {Apellido}";
        }

        #endregion

        #region delegados y eventos

        public delegate void DelegadoString(string mensaje);


        #endregion
    }
}
