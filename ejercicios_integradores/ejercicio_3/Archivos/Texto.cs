using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ejercicio_3.Excepciones;

namespace ejercicio_3.Archivos
{
    public class Texto : IArchivo<string>
    {
        #region metodos
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                if (File.Exists(archivo))
                {
                    using (FileStream stream = new FileStream(archivo, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(stream, datos);
                        retorno = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }

            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            BinaryFormatter formatter = new BinaryFormatter();
            datos = "";

            try
            {
                if (File.Exists(archivo))
                {
                    using (FileStream stream = new FileStream(archivo, FileMode.Open))
                    {
                        datos = (string)formatter.Deserialize(stream);
                        retorno = true;
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }


            return retorno;
        }
        #endregion

    }
}
