using System.Configuration;

namespace sql_dapper
{
    public class Helper
    {
        public static string CnnVal(string nombre)
        {
            return ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
        }
    }
}
