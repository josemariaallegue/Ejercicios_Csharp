using System;
using System.Xml.Serialization;
using System.IO;
using ejercicio_3.Excepciones;

namespace ejercicio_3.Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region metodos
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            try
            {
                if (File.Exists(archivo))
                {
                    using (TextWriter writer = new StreamWriter(archivo))
                    {
                        serializador.Serialize(writer, datos);
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

        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            datos = default(T);

            try
            {
                if (File.Exists(archivo))
                {
                    using (StreamReader reader = new StreamReader(archivo))
                    {
                        datos = (T)serializador.Deserialize(reader);
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
