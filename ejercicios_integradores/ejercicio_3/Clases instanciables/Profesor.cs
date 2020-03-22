using System;
using System.Collections.Generic;
using System.Text;
using ejercicio_3.Clases_abstractas;

namespace ejercicio_3.Clases_instanciables
{
    public sealed class Profesor:Universitario
    {
        #region campos y propiedades

        private Queue<Universidad.EClases> _clasesDelDia;
        private static Random _random;

        #endregion

        #region constructores

        static Profesor()
        {
            _random = new Random();
        }

        public Profesor()            
        {
            _clasesDelDia = new Queue<Universidad.EClases>();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id, nombre, apellido, dni, nacionalidad)
        {

        }

        #endregion

        #region metodos y sobrecargas

        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.MostrarDatos());
            retorno.Append(ParticiparEnClase());

            return retorno.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Clases del dia: ");
            foreach (Universidad.EClases clase in _clasesDelDia)
            {
                retorno.Append($"{clase} ");
            }
            retorno.AppendLine();

            return retorno.ToString();;
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        private void RamdonClases()
        {
            Universidad.EClases.1;
        }

        public static bool operator ==(Profesor profesor, Universidad.EClases clase)
        {
            bool retorno = false;

            if (profesor._clasesDelDia.Contains(clase))
            {
                retorno = true;
            }

            return retorno; 
        }

        public static bool operator !=(Profesor profesor, Universidad.EClases clase)
        {
            return !(profesor == clase);
        }

        #endregion
    }
}
