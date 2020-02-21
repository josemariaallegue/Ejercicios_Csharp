using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_32
{
    class Jugador
    {
        #region campos

        private long _dni;
        private string _nombre;
        private int _partidosJugados;
        private int _totalGoles;

        #endregion

        #region propiedades

        public long Dni
        {
            get => this._dni;
            set => this._dni = value;
        }

        public string Nombre
        {
            get => this._nombre;
            set => this._nombre = value;
        }

        public int PartidosJugados
        {
            get => this._partidosJugados;
        }

        public float PromedioGoles
        {
            get => this._totalGoles / this._partidosJugados;
        }

        public int TotalGoles
        {
            get => this._totalGoles;
        }

        #endregion

        #region constructores

        private Jugador()
        {
            this._partidosJugados = 0;
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
        }


        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat($"Nombre: {this._nombre}").AppendLine();
            texto.AppendFormat($"Dni: {this._dni}").AppendLine();
            texto.AppendFormat($"Total de partidos: {this._partidosJugados}").AppendLine();
            texto.AppendFormat($"Total de goles: {this._totalGoles}").AppendLine();
            texto.AppendFormat($"Promedio de goles: {this.PromedioGoles}").AppendLine();

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
