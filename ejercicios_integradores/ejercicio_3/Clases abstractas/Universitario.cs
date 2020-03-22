using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_3.Clases_abstractas
{
    public abstract class Universitario : Persona
    {
        #region campos y propiedades

        private int _legajo;

        #endregion

        #region constructores

        public Universitario()
            : base()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            _legajo = legajo;
        }

        #endregion

        #region metodos y sobrecargas

        protected virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(this.ToString());
            retorno.Append($"Legajo: {_legajo}").AppendLine();

            return retorno.ToString();
        }

        protected abstract string ParticiparEnClase();

        public override bool Equals(object obj)
        {
            bool retorno = false;
            Universitario universitarioAux = obj as Universitario;

            if(obj != null && (object)universitarioAux != null && this == universitarioAux)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(Universitario universitario1, Universitario universitario2)
        {
            bool retorno = false;

            if ((universitario1._legajo == universitario2._legajo || universitario1.Dni == universitario2.Dni)
                && universitario1.GetType() == universitario2.GetType())
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Universitario universitario1, Universitario universitario2)
        {
            return !(universitario1 == universitario2);
        }

        #endregion
    }
}
