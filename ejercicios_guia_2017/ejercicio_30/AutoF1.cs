using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_30
{
    class AutoF1
    {
        #region campos

        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        #endregion

        #region constructores

        public AutoF1(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        #endregion

        #region propiedades

        public short CantidadCombustible
        {
            get => _cantidadCombustible;
            set => _cantidadCombustible = value;
        }

        public bool EnCompetencia
        {
            get => _enCompetencia;
            set => _enCompetencia = value;
        }

        public short VueltasRestantes
        {
            get => _vueltasRestantes;
            set => _vueltasRestantes = value;
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(AutoF1 a1, AutoF1 a2) 
        {
            bool retorno = false;

            if(a1._numero == a2._numero && a1._escuderia == a2._escuderia)
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
