using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_29
{
    class Jugador
    {
        #region campos

        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        #endregion

        #region constructores

        private Jugador()
        {
            this._partidosJugados = 0;
            this._promedioGoles = 0;
            this._totalGoles = 0;
        }

        public Jugador(string nombre, long dni)
            : this()
        {
            this._nombre = nombre;
            this._dni = dni;
        }

        public Jugador(string nombre,long dni, int totalGoles, int totalPartidos)
            : this(nombre, dni)
        {
            this._totalGoles = totalGoles;
            this._partidosJugados = totalPartidos;
            this._promedioGoles = GetPromedioGoles();
        }


        #endregion

        #region metodos

        public float GetPromedioGoles()
        {
            return this._totalGoles / this._partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat($"Nombre: {this._nombre}").AppendLine();
            texto.AppendFormat($"Dni: {this._dni}").AppendLine();
            texto.AppendFormat($"Total de partidos: {this._partidosJugados}").AppendLine();
            texto.AppendFormat($"Total de goles: {this._totalGoles}").AppendLine();
            texto.AppendFormat($"Promedio de goles: {this._promedioGoles}").AppendLine();

            return texto.ToString();
        }

        public static bool  operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if(j1._dni == j2._dni)
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
