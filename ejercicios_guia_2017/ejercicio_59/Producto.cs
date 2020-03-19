using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_59
{
    public class Producto
    {
        #region propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Peso { get; set; }

        public string FullData
        {
            get
            {
                return $"Id: {Id}, Nombre: {Nombre}, Cantidad: {Cantidad}, Precio: {Precio}, Peso: {Peso}";
            }
        }

        #endregion

        #region constructores

        //los parametros que recibe el constructor tienen que tener la misma nomenclatura
        //que los campos de la base de datos
        public Producto(int id, string nombre, int cantidad, decimal precio, decimal peso)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            Peso = peso;
        }

        #endregion
    }
}
