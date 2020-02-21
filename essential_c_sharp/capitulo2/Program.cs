using System;
using System.Text;

namespace capitulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //anotacion cientifica se pone E + integer + suffix determinando tipo
            //Console.WriteLine(6.023E23F);

            //el simbolo @ permite escribir en pantalla exactamente como esta codeado
            //System.Console.Write(@"
            //            /\
            //           /  \
            //          /    \
            //         /      \
            //        /________\");

            //interpolation +  @
            //string nombre = "Jose Maria";
            //string apellido = "Allegue";
            //Console.WriteLine($@"Your full name is:
            //{ nombre } { apellido }");

            //para evitar errores de compatibilidad de sistemas operativos al usar \n o similares
            //se usa (en el caso de \n) environment.newline o writeline
            //Console.Write("Hola mundo" + Environment.NewLine);
            //Console.Write("Adios mudno" + Environment.NewLine);

            //como los strings son inmutables, se recomienda usar la clase stringbuilder
            //tiene algunos metodos iguales y permiti modificar texto sin la necesidad usar memoria
            //StringBuilder texto = new StringBuilder("Hola mundo");
            //texto.Append(", como estas!");
            //Console.WriteLine(texto);
            //Console.WriteLine(texto.Length);
            //texto.Remove(5,7);
            //texto.Insert(4, ",");
            //texto.Replace("!", "?");
            //Console.WriteLine(texto);

            //las variables tipo var deben ser inicializadas cuando son declaradas y son 
            //mayormente usados con anonymous types
            //var aux = "hola mudno";
            //var tipoAnonimo1 = new {titulo = "1984", hojas = 50};
            //Console.WriteLine($"Libro: {tipoAnonimo1.titulo}\nCantidad de hojas: {tipoAnonimo1.hojas}");

            //null modifier, el ? luego del tipo de la variable permite asignarle null
            //sirve para manejo de bases de datos
            //int? numeroAux = 10;
            //Console.WriteLine(numeroAux is null ? "True" : numeroAux.ToString());

            //arrays
            string[] nombres = { "Jose", "Maria", "Cristina" }; //unidimensional
            string[] nombres2;
            int[] numeros = new int[2]; //se inicializan automaticamente a los valores predeterminados
            nombres2 = new string[] { "Jose", "Maria", "Cristina" };

            int[,] celdas; //multidimensional
            celdas = new int[3,3] { {1, 0, 2},
                                    {1, 2, 0},
                                    {1, 2, 1}}; //si o si la inicializacion tiene que tener la cantidad de "dimensiones"


            Console.WriteLine(nombres[0]);
            Array.Sort(nombres); //ordenamiento de arrays
            Console.WriteLine(nombres[0]);
            Console.WriteLine($"Cristina esta en la posicion: {Array.BinarySearch(nombres, "Cristina")}"); //busqueda del index
            Array.Reverse(nombres); //invierte el orden de los elementos
            Array.Clear(nombres2, 0, nombres2.Length); //limpio el array, en realidad pones los valores predeterminados
            Console.WriteLine(nombres2[0]);
            Console.WriteLine($"El array celdas tiene {celdas.GetLength(1)} elementos en la segunda dimension"); /*.GetLength trae la 
            cantidad de elementos en una dimension*/
            Console.WriteLine($"El array celdas tiene {celdas.Rank} dimensiones"); /*.Rank trae la cantidad total de 
            dimensiones*/

            //jagged arrays o array de arrays
            //int[][] celdas2 =
            //{
            //    new int[]{1, 0, 2, 0},
            //    new int[]{1, 2, 0},
            //    new int[]{100, 2},
            //    new int[]{1}
            //};

            //Console.WriteLine(celdas2[2][0]);
            //Console.WriteLine(celdas2.Length);

        }
    }
}
