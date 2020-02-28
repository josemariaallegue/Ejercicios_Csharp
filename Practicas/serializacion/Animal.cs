using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace serializacion
{
    [Serializable()]
    class Animal:ISerializable
    {
        #region campos

        public string Nombre { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }

        #endregion 

        #region constructores

        public Animal(string nombre, float altura, float peso)
        {
            Nombre = nombre;
            Altura = altura;
            Peso = peso;
        }

        #endregion

        #region metodos

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nombre", Nombre);
            info.AddValue("Altura", Altura);
            info.AddValue("Peso", Peso);
        }

        public Animal(SerializationInfo info, StreamingContext context)
        {
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Altura = (float)info.GetValue("Altura", typeof(float));
            Peso = (float)info.GetValue("Peso", typeof(float));
        }
        #endregion
    }
}
