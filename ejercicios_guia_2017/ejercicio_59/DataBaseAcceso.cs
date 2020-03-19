using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System;

namespace ejercicio_59
{
    public static class DataBaseAcceso
    {
        public static List<Producto>  ObtenerProductos(string id)
        {
            int aux;
            List<Producto> productos = new List<Producto>();

            using (IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString("ProductoDB")))
            {
                if (id == "*")
                {
                    productos = coneccion.Query<Producto>("Select * from Productos").ToList();
                }
                else if (int.TryParse(id, out aux))
                {
                    productos = coneccion.Query<Producto>($"Select * from Productos where id = {id}").ToList();
                }
            }

            return productos;
        }

        public static void ModificarProducto(string id, string nombre, string cantidad, string precio, string peso)
        {
            Producto producto = new Producto(Convert.ToInt32(id),nombre, Convert.ToInt32(cantidad), Convert.ToDecimal(precio), Convert.ToDecimal(peso));

            using (IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString("ProductoDB")))
            {
                coneccion.Execute($"Update Productos set Nombre = @Nombre, Cantidad = @Cantidad, Precio = @Precio, Peso = @Peso " +
                    $"where Id = @Id", producto);
            }
        }

        public static void AgregarProducto(string nombre, string cantidad, string precio, string peso)
        {
            Producto producto = new Producto(0, nombre, Convert.ToInt32(cantidad), Convert.ToDecimal(precio), Convert.ToDecimal(peso));

            using (IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString("ProductoDB")))
            {
                coneccion.Execute($"Insert into Productos  values (@Nombre, @Cantidad, @Precio, @Peso)",producto);
            }
        }
    }
}
