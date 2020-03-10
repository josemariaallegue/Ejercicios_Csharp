using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace sql_dapper
{
    public class DataAcces
    {
        public List<Persona> ObtenerPersona(string apellido)
        {
            List<Persona> listaPersonas = new List<Persona>();

            using (IDbConnection coneccion = new SqlConnection(Helper.CnnVal("PersonasDB")))
            {
                //mala practica
                return coneccion.Query<Persona>($"select * from personasTabla where apellido = '{apellido}'").ToList();

                //buena practica es usar stored procedures y clases dinamicas
                //return coneccion.Query<Persona>("dbo.storedprocedure @LastName", new {LastName = apellido}).ToList();

            }
        }

        public void AgregarPersona(string id, string nombre, string apellido, string nacionalidad)
        {
            List<Persona> personas = new List<Persona>();
            Persona persona = new Persona(Convert.ToInt32(id), nombre, apellido, nacionalidad);

            personas.Add(new Persona(Convert.ToInt32(id), nombre, apellido, nacionalidad));

            using (IDbConnection coneccion = new SqlConnection(Helper.CnnVal("PersonasDB")))
            {
                //mala practica
                //funciona pasandole un objeto o lista
                coneccion.Execute($"insert into personasTabla values (@ID, @NOMBRE, @APELLIDO, @NACIONALIDAD)", persona);
            }
        }
    }
}
