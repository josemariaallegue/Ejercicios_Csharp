using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37
{
    public class Centralita
    {
        private List<LLamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                float retorno = 0;

                foreach(LLamada l in listaDeLlamadas)
                {
                    if(l is Local)
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
                    else if(l is Local)
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

        public Centralita()
        {
            this.listaDeLlamadas = new List<LLamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

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
                if(l is Local)
                {
                    retorno.AppendFormat("{0}\n", ((Local)l).Mostrar());
                }
                else if(l is Provincial)
                {
                    retorno.AppendFormat("{0}\n", ((Provincial)l).Mostrar());
                }
            }

            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(LLamada.OrdenarPorDuracion);
        }
    }
}
