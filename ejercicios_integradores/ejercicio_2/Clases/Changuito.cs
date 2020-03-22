using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        #region campos y propiedades
        public enum ETipo
        {
            Dulce,
            Leche,
            Snacks,
            Todos
        }

        private int _espacioDisponible;
        private List<Producto> _productos;

        #endregion

        #region constructores

        private Changuito()
        {
            this._productos = new List<Producto>();
        }
        public Changuito(int espacioDisponible)
            : this()
        {
            this._espacioDisponible = espacioDisponible;
        }

        #endregion

        #region metodos y sobrecargas

        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Tenemos {c._productos.Count} lugares ocupados de un total de {c._espacioDisponible} disponibles").AppendLine();

            // Aprovechar polimorfismo
            foreach (Producto productoAux in c._productos)
            {
                if (tipo == ETipo.Snacks && productoAux.GetType() == typeof(Snacks))
                {
                    retorno.Append(((Snacks)productoAux).Mostrar()).AppendLine();
                }
                else if (tipo == ETipo.Dulce && productoAux.GetType() == typeof(Dulce))
                {
                    retorno.Append(((Dulce)productoAux).Mostrar()).AppendLine();
                }
                else if (tipo == ETipo.Leche && productoAux.GetType() == typeof(Leche))
                {
                    retorno.Append(((Leche)productoAux).Mostrar()).AppendLine();
                }
                else if (tipo == ETipo.Todos)
                {
                    retorno.Append(productoAux.Mostrar()).AppendLine();
                }
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            bool flag = true;

            if (c._productos.Count < c._espacioDisponible)
            {
                foreach (Producto productoAux in c._productos)
                {
                    if (productoAux == p)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    c._productos.Add(p);
                }
            }

            return c;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto productoAux in c._productos)
            {
                if (productoAux == p)
                {
                    c._productos.Remove(productoAux);
                    break;
                }
            }

            return c;
        }

        #endregion
    }
}
