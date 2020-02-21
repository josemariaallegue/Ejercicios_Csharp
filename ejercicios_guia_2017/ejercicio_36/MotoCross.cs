using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_36
{
    class MotoCross:VehiculoDeCarrera
    {

        #region campos

        private short _cilindrada;

        #endregion

        #region propiedades

        public short Cilindrada
        {
            get => this._cilindrada;
            set => this._cilindrada = value;
        }

        #endregion

        #region constructores

        public MotoCross(short numero, string escuderia)
            :base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada)
            :this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.MostrarDatos()).AppendLine();
            texto.Append($"Cilindrada: {this.Cilindrada}");

            return texto.ToString();
        }
        #endregion

        #region sobrecargas

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;

            if(((VehiculoDeCarrera)m1) == ((VehiculoDeCarrera)m2) && m1.Cilindrada == m2.Cilindrada)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1==m2);
        }

        #endregion
    }
}
