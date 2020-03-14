using System;
using System.IO;

namespace ejercicio_56
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directorioBinario = new DirectoryInfo(@"..\..\..\Archivos\personaBinario.txt");
            DirectoryInfo directiorioXml = new DirectoryInfo(@"..\..\..\Archivos\personaXml.txt");
            DirectoryInfo directorioJson = new DirectoryInfo(@"..\..\..\Archivos\personaJson.txt");
            Persona persona = new Persona("Jose", "Allegue");
            Persona personaAux = null;

            Persona.Guardar(persona, directorioBinario.FullName, Serializador.Binario);
            personaAux =  Persona.Leer(directorioBinario.FullName, Serializador.Binario);
            Console.WriteLine(personaAux.ToString());

            personaAux = null;
            Persona.Guardar(persona, directorioJson.FullName, Serializador.Json);
            personaAux = Persona.Leer(directorioJson.FullName, Serializador.Json);
            Console.WriteLine(personaAux.ToString());

            personaAux = null;
            Persona.Guardar(persona, directorioJson.FullName, Serializador.Json);
            personaAux = Persona.Leer(directorioJson.FullName, Serializador.Json);
            Console.WriteLine(personaAux.ToString());
        }
    }
}
