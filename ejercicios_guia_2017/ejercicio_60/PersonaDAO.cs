using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace ejercicio_60
{
    public static class PersonaDAO
    {
        #region campos

        private static string nombreDB = "PersonaDB";

        #endregion

        #region metodos

        public static void Guardar(Persona persona)
        {
            using (IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString(nombreDB)))
            {
                //para que funcionen los @datos las propiedades de la clase deben ser publicas
                coneccion.Execute("Insert into Personas values (@Nombre, @Apellido, @Nacionalidad)", persona);
            }
        }

        public static List<Persona> Leer(string id)
        {
            List<Persona> personas = null;
            int idAux;

            using (IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString(nombreDB)))
            {
                if (id == "*" || id == "")
                {
                    personas = coneccion.Query<Persona>("Select * from Personas").ToList();
                }
                else if(int.TryParse(id, out idAux))
                {
                    personas = coneccion.Query<Persona>($"Select * from Personas where Id = {id}").ToList();
                }               
            }

            return personas;

        }

        public static List<Persona> LeerPorId(string id)
        {
            return Leer(id);
        }
        
        public static void Modificar (Persona persona)
        {
            using(IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString(nombreDB)))
            {
                coneccion.Execute($"Update Personas set Nombre = @Nombre, Apellido = @Apellido, Nacionalidad = @Nacionalidad " +
                    $"Where Id = @Id", persona);
            }

        }

        public static void Borrar(string id)
        {
            int idAux;

            if (int.TryParse(id, out idAux)) 
            {
                using (IDbConnection coneccion = new SqlConnection(Conector.BuscarConectionString(nombreDB)))
                {
                    coneccion.Execute($"Delete from Personas where Id = {id}");
                }
            }
            
        }

        #endregion
    }
}
