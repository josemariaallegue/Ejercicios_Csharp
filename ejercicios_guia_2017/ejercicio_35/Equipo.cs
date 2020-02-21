using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_35
{
    class Equipo
    {
        #region campos

        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        #endregion

        #region constructor
        
        private Equipo()
        {
            this._jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre)
            :this()
        {
            this._cantidadDeJugadores = cantidadJugadores;
            this._nombre = nombre;
        }

        #endregion 

        #region metodos

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            bool flag = true;

            foreach(Jugador jAuxiliar in e._jugadores)
            {
                if(j == jAuxiliar )
                {
                    flag = false;
                    break;
                }
            }

            if(flag == true && e._cantidadDeJugadores > e._jugadores.Count)
            {
                e._jugadores.Add(j);
                retorno = true;
            }

            return retorno;
        }

        #endregion
    }
}
