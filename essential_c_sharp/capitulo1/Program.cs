using System;

namespace capitulo1
{
    class Program
    {   
        static void Main(string[] args)
        {
            //hello world
            //Console.WriteLine("Hello World!");

            //declaracion variables
            //string texto1 = "Hola mundo!", texto2 = "Adios mundo!";
            //Console.WriteLine(texto1);
            //Console.WriteLine(texto2);
            //texto1 = texto2 = "Apocalipsis";
            //Console.WriteLine(texto2);

            //inputs
            //string textoInput;
            //Console.WriteLine(textoInput = Console.ReadLine());
            
            //console.read() devuelve un int por lo que hay que convertirlo a char
            //int leerValor;
            //char caracter;
            //leerValor = Console.Read();
            //caracter = (char)leerValor;
            //Console.WriteLine(leerValor);

            //console.readkey() conversiones para imprimir la tecla
            //ConsoleKeyInfo leerKey;
            //leerKey = Console.ReadKey();
            //Console.WriteLine(leerKey.Key.ToString());

            //string interpolation y composite formatting
            string nombre = "Jose", apellido = "Allegue";
            Console.WriteLine($"Tu nombre es: {nombre} {apellido}");
            Console.WriteLine("Tu nombre es: {0} {1}", nombre, apellido);
      


            

        }
    }
}
