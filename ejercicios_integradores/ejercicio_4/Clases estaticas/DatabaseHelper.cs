using System.Configuration;

namespace ejercicio_4.Clases_estaticas
{
    public static class DataBaseHelper
    {
        #region metodos y sobrecargas

        public static string ConnectionStringName(string nombre)
        {
            return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
        }

        #endregion
    }
}
