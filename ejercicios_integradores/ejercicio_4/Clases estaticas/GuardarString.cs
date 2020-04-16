using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ejercicio_4.Clases_estaticas
{
    public static class GuardaString
    {
        #region metodos y sobrecargas

        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = false;
            BinaryFormatter formatter = new BinaryFormatter();

            if (File.Exists(archivo))
            {
                using (FileStream stream = new FileStream(archivo, FileMode.Append))
                {
                    formatter.Serialize(stream, texto);
                    retorno = true;
                }
            }
            else
            {
                using (FileStream stream = new FileStream(archivo, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(stream, texto);
                    retorno = true;
                }
            }

            return retorno;
        }

        #endregion
    }
}
