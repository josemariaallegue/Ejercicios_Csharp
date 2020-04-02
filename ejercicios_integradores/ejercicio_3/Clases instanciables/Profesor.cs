using System;
using System.Collections.Generic;
using System.Text;
using ejercicio_3.Clases_abstractas;

namespace ejercicio_3.Clases_instanciables
{
    public sealed class Profesor : Universitario
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

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            _clasesDelDia = new Queue<Universidad.EClases>();
            RamdonClases();
            RamdonClases();
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
                retorno.Append($"{clase.ToString()} ");
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
            Array clases = Enum.GetValues(typeof(Universidad.EClases));
            _clasesDelDia.Enqueue((Universidad.EClases)clases.GetValue(_random.Next(clases.Length)));
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
