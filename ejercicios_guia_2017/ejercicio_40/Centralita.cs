using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_40
{
    class Centralita
    {
        #region campos

        private List<Llamada> _listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region propiedades

        public float GananciasPorLocal
        {
            get => this.CalcularGanancia(TipoLlamada.Local);
        }

        public float GananciasPorProvincial
        {
            get => this.CalcularGanancia(TipoLlamada.Provincial);
        }

        public float GananciasPorTotal
        {
            get => this.CalcularGanancia(TipoLlamada.Todas);
        }

        #endregion

        #region constructores

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public  Centralita(string nombreEmpresea)
            : this()
        {
            this.razonSocial = nombreEmpresea;
        }

        #endregion

        #region metodos

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0;

            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach(Llamada llamadaAux in this._listaDeLlamadas)
                    {
                        if(llamadaAux is Local)
                        {
                            retorno += llamadaAux.CostoLlamada;
                        }
                    }
                    break;

                case TipoLlamada.Provincial:
                    foreach(Llamada llamadaAux in this._listaDeLlamadas)
                    {
                        if(llamadaAux is Provincial)
                        {
                            retorno += llamadaAux.CostoLlamada;
                        }
                    }
                    break;

                case TipoLlamada.Todas:
                    foreach(Llamada llamadaAux in this._listaDeLlamadas)
                    {
                        retorno += llamadaAux.CostoLlamada;
                    }
                    break;
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Razon social: {this.razonSocial}").AppendLine();
            retorno.Append($"Ganancias por local: {this.GananciasPorLocal}").AppendLine();
            retorno.Append($"Ganancias por provincial: {this.GananciasPorProvincial}").AppendLine();
            retorno.Append($"Ganancias totales: {this.GananciasPorTotal}").AppendLine();

            foreach(Llamada llamadaAux in this._listaDeLlamadas)
            {
                retorno.Append($"\nLlamada:").AppendLine();
                retorno.Append($"{llamadaAux.ToString()}").AppendLine();
            }

            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamada aux;

            for (int i = 1; i < this._listaDeLlamadas.Count; i++)
            {
                for (int j = 0; j < this._listaDeLlamadas.Count; j++)
                {
                    if (this._listaDeLlamadas[i].CostoLlamada > this._listaDeLlamadas[j].CostoLlamada)
                    {
                        aux = this._listaDeLlamadas[i];
                        this._listaDeLlamadas[i] = this._listaDeLlamadas[j];
                        this._listaDeLlamadas[j] = aux;
                    }
                }
            }
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }


        #endregion

        #region sobrecargas

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            bool retorno = false;

            foreach(Llamada llamadaAux in central._listaDeLlamadas)
            {
                if(llamadaAux == llamada)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita central, Llamada llamada)
        {
            return !(central == llamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if(central != nuevaLlamada)
            {
                central.AgregarLlamada(nuevaLlamada);
            }

            return central;
        }

        #endregion
    }
}
