using System;
using System.Reflection;

namespace serializacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona() { Nombre = "Jose", Edad = 10 };
            Persona personaAux = null;
            Persona personaAux2 = null;
            Persona personaAux3 = null;
            string rutaArchivo = "";
            Serializador serializador1 = new Serializador(typeof(Persona));

            Serializador.serializadorBinario(persona1, rutaArchivo);
            personaAux = (Persona)Serializador.desSerializadorBinario(rutaArchivo);
            Console.WriteLine(personaAux.ToString());

            Serializador.serializadorXml(typeof(Persona), persona1, rutaArchivo);
            personaAux2 = (Persona)Serializador.desSerializadorXml(typeof(Persona), rutaArchivo);
            Console.WriteLine(personaAux2.ToString());

            Serializador.serializadorJson(persona1, rutaArchivo);
            personaAux3 = (Persona)Serializador.desSerializadorJson(typeof(Persona), rutaArchivo);
            Console.WriteLine(personaAux3.ToString());

        }
    }
}
