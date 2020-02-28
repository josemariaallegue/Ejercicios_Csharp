using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;

namespace serializacion_2
{
    static class Serializador
    {
        public static void serializadorBinario(object obj, string rutaArchivo)
        {
            FileStream fileStreamAux = File.Open(rutaArchivo, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fileStreamAux, obj);

            fileStreamAux.Close();
        }

        public static object desSerializadorBinario(string rutaArchivo)
        {
            object obj = null;

            FileStream fileStreamAux;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(rutaArchivo))
            {
                fileStreamAux = File.OpenRead(rutaArchivo);
                obj = bf.Deserialize(fileStreamAux);

                fileStreamAux.Close();
            }

            return obj;
        }

        public static void serializadorXml(Type tipoObjeto, object obj, string rutaArchivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(tipoObjeto);

            if (File.Exists(rutaArchivo))
            {
                TextWriter writer = new StreamWriter(rutaArchivo);
                xmlSerializer.Serialize(writer, obj);
                writer.Close();
            }
        }

        public static object desSerializadorXml(Type tipoObjeto, string rutaArchvivo)
        {
            object obj = null;
            XmlSerializer xmlSerializer = new XmlSerializer(tipoObjeto);

            if (File.Exists(rutaArchvivo))
            {
                TextReader reader = new StreamReader(rutaArchvivo);
                obj = xmlSerializer.Deserialize(reader);
                reader.Close();
            }

            return obj;

        }
    }
}
