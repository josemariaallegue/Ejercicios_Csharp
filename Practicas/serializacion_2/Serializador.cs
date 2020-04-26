using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.Reflection;


namespace serializacion_2
{
     class Serializador:IFormatter
    {
        #region campos

        private Type Tipo { get; set; }

        #endregion

        #region constructores

        public Serializador(Type tipo)
        {
            Tipo = tipo;
        }

        #endregion

        #region metodos para serializacion binaria
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

        #endregion

        #region metodos para serializacion xml
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

        #endregion

        #region metodos para serializacion json
        public static void serializadorJson(object obj, string rutaArchivo) 
        {
            JsonSerializer serializador = new JsonSerializer();

            if (File.Exists(rutaArchivo))
            {
                StreamWriter writer = new StreamWriter(rutaArchivo);
                JsonWriter jsonWriter = new JsonTextWriter(writer);
                serializador.Serialize(jsonWriter, obj);
                jsonWriter.Close();
                writer.Close();
            }
        }

        public static object desSerializadorJson(Type tipoObjeto, string rutaArchivo) 
        {
            JObject jObjectAux = null;
            JsonSerializer serializador = new JsonSerializer();

            if (File.Exists(rutaArchivo))
            {
                StreamReader reader = new StreamReader(rutaArchivo);
                JsonReader readerJson = new JsonTextReader(reader);
                jObjectAux = (JObject) serializador.Deserialize(readerJson);

                readerJson.Close();
                reader.Close();
            }

            return jObjectAux.ToObject(tipoObjeto);
        }

        public void Serialize(Stream serializationStream, object graph)
        {
            List<PropertyInfo> propiedades = Tipo.GetProperties().ToList();
            StreamWriter writer = new StreamWriter(serializationStream);

            writer.WriteLine(Tipo.Name);
            foreach(PropertyInfo propiedad in propiedades)
            {
                writer.WriteLine($"{propiedad.Name}:{propiedad.GetValue(graph)}");
            }

            writer.Close(); 
        }

        public object Deserialize(Stream serializationStream)
        {
            throw new NotImplementedException();
        }

        public SerializationBinder Binder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public StreamingContext Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ISurrogateSelector SurrogateSelector { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion
    }
}
