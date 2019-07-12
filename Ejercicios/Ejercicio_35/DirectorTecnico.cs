using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class DirectorTecnico:Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre)
            : base(nombre)
        {
 
        }

        private DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            string retorno = base.MostrarDatos();
            StringBuilder auxiliarRetorno = new StringBuilder();

            auxiliarRetorno.AppendFormat("Fecha de nacimiento: {0}", this.fechaNacimiento).ToString();

            retorno = retorno + " " + auxiliarRetorno;

            return retorno;
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool retorno = false;

            if (dt1.Dni == dt2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }


    }
}
