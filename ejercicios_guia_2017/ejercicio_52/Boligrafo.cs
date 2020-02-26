using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_52
{
    class Boligrafo:IAcciones
    {
        #region campos

        private ConsoleColor _colorTinta;
        private float _tinta;

        #endregion

        #region propiedades

        public ConsoleColor Color
        {
            get => this._colorTinta;
            set => this._colorTinta = value;
        }

        public float UnidadesDeEscritura
        {
            get => this._tinta;
            set => this._tinta = value;
        }

        #endregion

        #region constructores

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;
        }

        #endregion

        #region metodos

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escrituraAux = new EscrituraWrapper(texto, this.Color);

            this.UnidadesDeEscritura -= texto.Length * 0.3f;

            return escrituraAux;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;

            return true;
        }

        #endregion

        #region sobrecargas
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Tipo: Boligrafo").AppendLine();
            retorno.Append($"Color: {this.Color}").AppendLine();
            retorno.Append($"Cantidad restante: {this.UnidadesDeEscritura}").AppendLine();

            return retorno.ToString(); ;
        }

        #endregion
    }
}
