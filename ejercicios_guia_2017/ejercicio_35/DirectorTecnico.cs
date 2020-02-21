using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_35
{
    class DirectorTecnico:Persona
    {
        #region campos 

        private DateTime _fechaNacimiento;

        #endregion

        #region constructores

        public DirectorTecnico(string nombre)
            :base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : base(nombre)
        {
            this._fechaNacimiento = fechaNacimiento;
        }

        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.MostrarDatos()).AppendLine();
            texto.AppendFormat($"Fecha de nacimiento: {this._fechaNacimiento}").AppendLine();

            return texto.ToString();
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            bool retorno = false;

            if(d1.Dni == d2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator != (DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1== d2);
        }

        #endregion


    }
}
