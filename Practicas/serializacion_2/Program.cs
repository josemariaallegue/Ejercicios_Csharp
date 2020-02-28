using System;

namespace serializacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona() { Nombre = "Jose", Edad = 10 };
            Persona personaAux = null;
            Persona personaAux2 = null;
            string rutaArchivo = "";

            Serializador.serializadorBinario(persona1, rutaArchivo);
            personaAux = (Persona)Serializador.desSerializadorBinario(rutaArchivo);

            Serializador.serializadorXml(typeof(Persona), persona1, rutaArchivo);
            personaAux2 = (Persona)Serializador.desSerializadorXml(typeof(Persona), rutaArchivo);
        }
    }
}
