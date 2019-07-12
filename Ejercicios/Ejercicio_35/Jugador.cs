using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Jugador:Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public float PromedioDeGoles
        {
            get
            {
                return this.GetPromedioGoles();
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }

            set
            {
                this.totalGoles = value;
            }
        }

        private Jugador(string nombre, int totalGoles, int totalPartidos)
            : base(nombre)
        {
            this.TotalGoles = totalGoles;
            this.PartidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            float retorno = 0;

            if (this.partidosJugados != 0)
            {
                retorno = this.totalGoles / this.partidosJugados;
            }

            return retorno;
        }

        public string MostrarDatos()
        {
            string retorno = base.MostrarDatos();
            StringBuilder auxiliarRetorno = new StringBuilder();

            auxiliarRetorno.AppendFormat("Partidos jugados: {0}, Total goles: {1} y Promedio goles: {2}", this.PartidosJugados, this.TotalGoles, this.PromedioDeGoles).ToString();

            retorno = retorno + "  " + auxiliarRetorno;

            return retorno;
            
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if (j1.Dni == j2.Dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }        
    }
}
