using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    public abstract class Producto
    {
        #region campos y propiedades
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }

        private string _codigoDeBarras;
        private ConsoleColor _colorPrimarioEmpaque;
        private EMarca _marca;

        protected abstract short CantidadCalorias { get; }

        #endregion

        #region constructores

        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            _codigoDeBarras = codigo;
            _marca = marca;
            _colorPrimarioEmpaque = color;
        }

        #endregion

        #region metodos y sobrecargas

        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static explicit operator string(Producto p)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Codigo de barras: {p._codigoDeBarras}").AppendLine();
            retorno.Append($"Marca: {p._marca}").AppendLine();
            retorno.Append($"Color del empaque: {p._colorPrimarioEmpaque}").AppendLine();
            retorno.AppendLine();
            retorno.Append($"---------------------------").AppendLine();
            retorno.AppendLine();
            retorno.Append($"Calorias: {p.CantidadCalorias}").AppendLine();
            retorno.AppendLine();
            retorno.Append($"---------------------------");

            return retorno.ToString();
        }

        public static bool operator ==(Producto v1, Producto v2)
        {
            return (v1._codigoDeBarras == v2._codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }

        #endregion
    }
}
