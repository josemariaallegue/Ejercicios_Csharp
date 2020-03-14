using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ejercicio_56
{
    public enum Serializador
    {
        Binario,
        Xml,
        Json
    }

    [Serializable]
    public class Persona
    {
        #region campos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region constructores
        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        #endregion

        #region metodos
        public static void Guardar(Persona persona, string ruta, Serializador tipoSerializacion)
        {
            switch (tipoSerializacion)
            {
                case Serializador.Binario:
                    using (FileStream archivo = File.Open(ruta, FileMode.OpenOrCreate))
                    {
                        BinaryFormatter bf = new BinaryFormatter();

                        bf.Serialize(archivo, persona);
                    }
                    break;

                case Serializador.Xml:
                    XmlSerializer serializadorXml = new XmlSerializer(typeof(Persona));

                    using(TextWriter writer = new StreamWriter(ruta))
                    {
                        serializadorXml.Serialize(writer, persona);
                    }
                    break;

                case Serializador.Json:
                    JsonSerializer serializadorJson = new JsonSerializer();

                    using (StreamWriter writer = new StreamWriter(ruta))
                    {
                        JsonWriter jsonWriter = new JsonTextWriter(writer);

                        serializadorJson.Serialize(jsonWriter, persona);
                        jsonWriter.Close();
                    }
                    break;
            }
            

        }

        public static Persona Leer(string ruta, Serializador tipoSerializacion)
        {
            Persona retorno = null;

            if (File.Exists(ruta))
            {
                switch (tipoSerializacion)
                {
                    case Serializador.Binario:
                        using (FileStream archivo = File.Open(ruta, FileMode.Open))
                        {
                            BinaryFormatter bf = new BinaryFormatter();

                            retorno = (Persona)bf.Deserialize(archivo);
                        }
                        break;

                    case Serializador.Xml:
                        XmlSerializer serializador = new XmlSerializer(typeof(Persona));

                        using (TextReader reader = new StreamReader(ruta))
                        {
                            retorno = (Persona)serializador.Deserialize(reader);
                        }
                        break;

                    case Serializador.Json:
                        JsonSerializer serializadorJson = new JsonSerializer();
                        JObject jObjectAux = null;
                        using (StreamReader reader = new StreamReader(ruta))
                        {
                            JsonReader jsonReader = new JsonTextReader(reader);

                            jObjectAux = (JObject) serializadorJson.Deserialize(jsonReader);
                            
                            jsonReader.Close();
                        }

                        retorno = (Persona)jObjectAux.ToObject(typeof(Persona));
                        break;
                }
                
            }
            
            return retorno;
        }
        #endregion

        #region
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Nombre: {Nombre}").AppendLine();
            retorno.Append($"Apellido: {Apellido}").AppendLine();

            return retorno.ToString();
        }
        #endregion
    }
}
