using System;
using System.Collections.Generic;
using System.Text;
using ejercicio_3.Clases_abstractas;

namespace ejercicio_3.Clases_instanciables
{
    public sealed class Alumno:Universitario
    {
        #region campos y propiedades

        public enum EEstadoCuenta { AlDia, Deudor, Becado}
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        #endregion

        #region constructores

        public Alumno()
            :base()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            :base(id, nombre, apellido, dni, nacionalidad)
        {
            _claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            _estadoCuenta = estadoCuenta;
        }


        #endregion

        #region metodos y sobrecargas

        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.MostrarDatos());
            retorno.Append($"Clase que toma: {_claseQueToma.ToString()}").AppendLine();
            retorno.Append($"Estado de la cuenta: {_estadoCuenta}").AppendLine();

            return retorno.ToString();
        }

        protected override string ParticiparEnClase()
        {
            return $"Toma clase de {_claseQueToma.ToString()}";
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            bool retorno = false;

            if(alumno._claseQueToma == clase && alumno._estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            bool retorno = false;

            if (alumno._claseQueToma != clase)
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion
    }
}
