using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_30
{
    class Competencia
    {
        #region campos

        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> _competidores;

        #endregion

        #region constructores

        private Competencia()
        {
            this._competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) 
            : this()
        {
            this._cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
        }

        #endregion

        #region metodos
        #endregion

        #region sobrecargas

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            foreach (AutoF1 autoAuxiliar in c._competidores)
            {
                if (autoAuxiliar == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c==a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random r1 = new Random();

            if((c!=a && c._cantidadCompetidores > c._competidores.Count))
            {
                c._competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c._cantidadVueltas;
                a.CantidadCombustible = (short)r1.Next(15, 100);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            Random r1 = new Random();

            if(c._competidores.Count >= 1)
            {
                for (int i = 0; i < c._competidores.Count; i++)
                {
                    if (c._competidores[i] == a)
                    {
                        c._competidores.Remove(a);
                        a.EnCompetencia = false;
                        a.VueltasRestantes = 0;
                        a.CantidadCombustible = 0;
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        #endregion

    }
}
