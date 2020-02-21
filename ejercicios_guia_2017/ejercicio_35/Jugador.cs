using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_35
{
    class Jugador:Persona
    {
        #region campos

        private int _partidosJugados;
        private int _totalGoles;

        #endregion

        #region propiedades

        public int PartidosJugados
        {
            get => this._partidosJugados;
            set => this._partidosJugados = value;
        }

        public float PromedioGoles
        {
            get => this._totalGoles / this._partidosJugados;
        }

        public int TotalGoles
        {
            get => this._totalGoles;
            set => this._totalGoles = value;
        }

        #endregion

        #region constructores

        public Jugador(string nombre,long dni, int totalGoles, int totalPartidos)
            :base(nombre, dni)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
        }


        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.MostrarDatos());
            texto.AppendFormat($"Total de partidos: {this.PartidosJugados}").AppendLine();
            texto.AppendFormat($"Total de goles: {this.TotalGoles}").AppendLine();
            texto.AppendFormat($"Promedio de goles: {this.PromedioGoles}").AppendLine();

            return texto.ToString();
        }

        public static bool  operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if(j1.Dni == j2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        #endregion
    }
}
