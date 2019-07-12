using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre; 
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;

            if (!(e.jugadores.Contains(j)) && e.jugadores.Count != e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                retorno = true;
            }

            return retorno;
        }
    }
}
