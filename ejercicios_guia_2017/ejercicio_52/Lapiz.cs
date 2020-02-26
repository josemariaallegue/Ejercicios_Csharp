using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_52
{
    class Lapiz:IAcciones
    {
        #region campos

        private float _tamanioMina;

        #endregion

        #region propiedades
        public ConsoleColor Color
        {
            get => ConsoleColor.Blue;
            set => throw new NotImplementedException();
        }

        public float UnidadesDeEscritura
        {
            get => this._tamanioMina;
            set => this._tamanioMina = value;
        }

        #endregion

        #region constructores

        public Lapiz (int unidades)
        {
            this.UnidadesDeEscritura = (float)unidades;
        }

        #endregion

        #region metodos

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraAux = new EscrituraWrapper(texto, this.Color);

            this.UnidadesDeEscritura -= texto.Length * 0.1f;

            return escrituraAux;
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region sobrecargas

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Tipo: Lapiz").AppendLine();
            retorno.Append($"Color: {this.Color}").AppendLine();
            retorno.Append($"Cantidad restante: {this.UnidadesDeEscritura}").AppendLine();

            return retorno.ToString(); ;
        }

        #endregion


    }
}
