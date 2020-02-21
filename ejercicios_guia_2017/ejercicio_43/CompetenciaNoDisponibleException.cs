using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_43
{
    class CompetenciaNoDisponibleException:Exception
    {
        #region campos

        private string _nombreClase;
        private string _nombreMetodo;

        #endregion

        #region propiedades

        public string NombreClase
        {
            get => this._nombreClase;
        }

        public string NombreMetodo
        {
            get => this._nombreMetodo;
        }

        #endregion

        #region constructores

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException)
            : base(mensaje, innerException)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        #endregion

        #region sobrecargas

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Excepción en el método {this.NombreMetodo} de la clase {this.NombreClase}").AppendLine();
            retorno.Append($"{this.Message}").AppendLine();
            retorno.Append($"{this.InnerException}").AppendLine();

            return retorno.ToString();
        }

        #endregion
    }
}
