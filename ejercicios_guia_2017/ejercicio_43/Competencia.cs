using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_43
{
    public enum TipoCompetencia
    {
        AutoF1,
        MotoCross
    }
    class Competencia
    {
        #region campos

        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> _competidores;
        private TipoCompetencia _tipo;

        #endregion

        #region propiedades

        public short CantidadCompetidores
        {
            get => this._cantidadCompetidores;
            set => this._cantidadCompetidores = value;
        }

        public short CantidadVueltas
        {
            get => this._cantidadVueltas;
            set => this._cantidadVueltas = value;
        }

        public VehiculoDeCarrera this[int i]
        {
            get => this._competidores[i];
        }

        public TipoCompetencia Tipo
        {
            get => this._tipo;
            set => this._tipo = value;
        }

        #endregion

        #region constructores

        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) 
            : this()
        {
            this._cantidadVueltas = cantidadVueltas;
            this._cantidadCompetidores = cantidadCompetidores;
            this.Tipo = tipo;
        }

        #endregion

        #region metodos

        public string MostrarDatos()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append($"Tipo de competencia: {this.Tipo}").AppendLine();
            texto.Append($"Cantidad de competidores: {this.CantidadCompetidores}").AppendLine();
            texto.Append($"Cantidad de vueltas: {this.CantidadVueltas}").AppendLine();

            for(int i = 0; i < this._competidores.Count; i++)
            {
                texto.Append($"Competidor {i}: {this[i]}").AppendLine();
            }

            return texto.ToString();

        }

        #endregion

        #region sobrecargas

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;

            if (Convert.ToString(c.Tipo) == Convert.ToString(v.GetType().Name))
            {
                for (int i = 0; i < c._competidores.Count; i++)
                {
                    if ((c[i]) == v)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", nameof(Competencia), "==");
            }
            


            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c==v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            Random r1 = new Random();

            try
            {
                if (c != v && c._cantidadCompetidores > c._competidores.Count )
                {
                    c._competidores.Add(v);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c._cantidadVueltas;
                    v.CantidadCombustible = (short)r1.Next(15, 100);
                    retorno = true;
                }
            }
            catch(CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", nameof(Competencia), "+", e);
            }

            return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            Random r1 = new Random();

            if(c._competidores.Count >= 1)
            {
                for (int i = 0; i < c._competidores.Count; i++)
                {
                    if (c[i]== v && Convert.ToString(c.Tipo) == Convert.ToString(v.GetType().Name))
                    {
                        c._competidores.Remove(v);
                        v.EnCompetencia = false;
                        v.VueltasRestantes = 0;
                        v.CantidadCombustible = 0;
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        #endregion

    }
}
