using System.Configuration;

namespace ejercicio_60
{
    public static class Conector
    {
        public static string BuscarConectionString(string nombre)
        {
            return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
        }
    }
}
