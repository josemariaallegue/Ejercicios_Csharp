using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_demo
{
    public enum Nacionalidades
    {
        Argentino,
        Paraguayo,
        Chileno
    }
    class Persona
    {
        #region campos

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public int Edad { get; set; }

        #endregion

        #region constructores

        public Persona(string nombre, string apellido, string nacionalidad, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            Edad = edad;
        }

        #endregion

        #region metodos

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Nombre: {Nombre}").AppendLine();
            retorno.Append($"Apellido: {Apellido}").AppendLine();
            retorno.Append($"Nacionalidad: {Nacionalidad}").AppendLine();
            retorno.Append($"Edad: {Edad}").AppendLine();

            return retorno.ToString();
        }

        #endregion

    }
}
