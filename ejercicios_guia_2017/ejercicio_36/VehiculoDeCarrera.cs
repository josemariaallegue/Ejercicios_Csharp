using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_36
{
    class VehiculoDeCarrera
    {
        #region campos

        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        #endregion

        #region propiedades

        public short CantidadCombustible
        {
            get => this._cantidadCombustible;
            set => this._cantidadCombustible = value;
        }

        public bool EnCompetencia
        {
            get => this._enCompetencia;
            set => this._enCompetencia = value;
        }

        public string Escuderia
        {
            get => this._escuderia;
            set => this._escuderia = value;
        }

        public short Numero
        {
            get => this._numero;
            set => this._numero = value;
        }

        public short VueltasRestantes
        {
            get => this._vueltasRestantes;
            set => this._vueltasRestantes = value;
        }

        #endregion

        #region constructores

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat($"Escuderia: {this.Escuderia}").AppendLine();
            texto.AppendFormat($"Numero: {this.Numero}").AppendLine();
            texto.AppendFormat($"En competencia: {this.EnCompetencia}").AppendLine();
            texto.AppendFormat($"Cantidad combustible: {this.CantidadCombustible}").AppendLine();
            texto.AppendFormat($"Vueltas restantes: {this.VueltasRestantes}").AppendLine();

            return texto.ToString();
        }

        #endregion

        #region sobrecargas

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool retorno = false;

            if(v1.Escuderia == v2.Escuderia && v1.Numero == v2.Numero && Convert.ToString(v1.GetType().Name) == Convert.ToString(v2.GetType().Name))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1==v2);
        }

        #endregion
    }
}
