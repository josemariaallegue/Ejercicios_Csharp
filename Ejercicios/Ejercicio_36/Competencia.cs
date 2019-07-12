using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    class Competencia
    {
        public enum TipoCompetencia
        {
            F1, MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }

            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }

            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }

            set
            {
                this.tipo = value;
            }
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo):this()
        {
            this.CantidadVueltas = cantVueltas;
            this.CantidadCompetidores = cantCompetidores;
            this.Tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder auxiliar = new StringBuilder();
            string retorno = "";
            
            retorno = auxiliar.AppendFormat("Tipo de competencia: {0}\nCantidad de competidores: {1}\nCantidad de vueltas: {2}\n", this.Tipo, this.CantidadCompetidores, this.CantidadVueltas).ToString();

            for (int i = 0; i < this.competidores.Count() - 1; i++)
            {
                retorno = auxiliar.AppendFormat("Competidores: {0}\n", this[i]).ToString();
            }
            return retorno;
        }

        //public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        //{
        //    bool retorno = false;

        //    if(c.tipo ==

        //    return retorno;
        //}

        //public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        //{ }

        //public static bool operator +(Competencia c, VehiculoDeCarrera a)
        //{ }

        //public static bool operator -(Competencia c, VehiculoDeCarrera a)
        //{ }
    }
}
