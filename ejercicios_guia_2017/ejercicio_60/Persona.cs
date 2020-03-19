using System.Text;

namespace ejercicio_60
{
    public class Persona
    {
        #region atributos

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }
        public string FullData
        {
            get
            {
                return $"{Id} {Nombre} {Apellido} {Nacionalidad}";
            }
        }

        #endregion

        #region constructores

        public Persona(string nombre, string apellido, string nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public Persona(int id, string nombre, string apellido, string nacionalidad)
            :this(nombre, apellido, nacionalidad)
        {
            Id = id;
        }

        #endregion
    }
}
