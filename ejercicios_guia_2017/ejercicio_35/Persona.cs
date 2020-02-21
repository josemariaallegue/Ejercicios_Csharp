using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_35
{
    class Persona
    {
        #region campos

        private long _dni;
        private string _nombre;

        #endregion

        #region propiedades

        public long Dni
        {
            get => this._dni;
            set => this._dni = value;
        }

        public string Nombre
        {
            get => this._nombre;
            set => this._nombre = value;
        }

        #endregion

        #region constructores

        public Persona(string nombre)
        {
            this.Nombre = nombre;
            this.Dni = 0;
        }

        public Persona(string nombre, long dni)
            :this(nombre)
        {
            this.Dni = dni;
        }

        #endregion

        #region medotos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat($"Nombre: {this.Nombre}").AppendLine();
            texto.AppendFormat($"Dni: {this.Dni}").AppendLine();

            return texto.ToString();

        }

        #endregion
    }
}
