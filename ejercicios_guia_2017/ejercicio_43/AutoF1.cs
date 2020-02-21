using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_43
{
    class AutoF1:VehiculoDeCarrera
    {
        #region campos

        private short _caballosDeFuerza;

        #endregion

        #region propiedades

        public short CaballosDeFuerza
        {
            get => this._caballosDeFuerza;
            set => this._caballosDeFuerza = value;
        }

        #endregion

        #region constructores

        public AutoF1(short numero, string escuderia)
            :base(numero,escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.MostrarDatos());
            texto.Append($"Caballos de fuerza: {this.CaballosDeFuerza}").AppendLine();

            return texto.ToString();
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(AutoF1 a1, AutoF1 a2) 
        {
            bool retorno = false;

            if(((VehiculoDeCarrera)a1) == ((VehiculoDeCarrera)a2) && a1.CaballosDeFuerza == a2.CaballosDeFuerza)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }

        #endregion
    }
}
