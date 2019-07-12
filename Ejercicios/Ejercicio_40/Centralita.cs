using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40
{
    public class Centralita
    {
        #region Atributos
        private List<LLamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                float retorno = 0;

                foreach (LLamada l in listaDeLlamadas)
                {
                    if (l is Local)
                    {
                        retorno = retorno + ((Local)l).CostoLlamada;
                    }
                }

                return retorno;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float retorno = 0;

                foreach (LLamada l in listaDeLlamadas)
                {
                    if (l is Provincial)
                    {
                        retorno = retorno + ((Provincial)l).CostoLlamada;
                    }
                }

                return retorno;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                float retorno = 0;

                foreach (LLamada l in listaDeLlamadas)
                {
                    if (l is Provincial)
                    {
                        retorno = retorno + ((Provincial)l).CostoLlamada;
                    }
                    else if (l is Local)
                    {
                        retorno = retorno + ((Local)l).CostoLlamada;
                    }
                    else
                    {
                        retorno = retorno + 0;
                    }
                }

                return retorno;
            }
        }

        public List<LLamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<LLamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(LLamada.TipoLlamada tipo)
        {
            float retorno = 0;

            foreach (LLamada l in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case LLamada.TipoLlamada.Local:
                        retorno = this.GananciasPorLocal;
                        break;

                    case LLamada.TipoLlamada.Provincial:
                        retorno = this.GananciasPorProvincial;
                        break;

                    case LLamada.TipoLlamada.Todos:
                        retorno = this.GananciasPorTotal;
                        break;

                    default:
                        retorno = 0;
                        break;
                }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Razon social: {0}\n\n", this.razonSocial);

            foreach (LLamada l in listaDeLlamadas)
            {
                if (l is Local)
                {
                    retorno.AppendFormat("{0}\n", ((Local)l).ToString());
                }
                else if (l is Provincial)
                {
                    retorno.AppendFormat("{0}\n", ((Provincial)l).ToString());
                }
            }

            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(LLamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(LLamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita c, LLamada l)
        {
            bool retorno = false;

            foreach(LLamada auxL in c.listaDeLlamadas)
            {
                if(auxL == l)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, LLamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, LLamada nuevaLlamada)
        {
            if(c!=nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }
        #endregion
    }
}
