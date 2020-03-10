

namespace sql_dapper
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string FullData
        {
            get
            {
                return $"{Id}, {Nombre}, {Apellido}, {Nacionalidad}";
            }
        }

        public Persona(int id, string nombre, string apellido, string nacionalidad)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }


    }
}
