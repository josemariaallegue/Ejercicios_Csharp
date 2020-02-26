using System;
using System.IO;
using System.Text;

namespace file_io
{
    class Program
    {
        static void Main(string[] args)
        {
            #region directorios

            DirectoryInfo directorioAux = new DirectoryInfo(".");

            //propiedases utiles de DirectoryInfo
            Console.WriteLine(directorioAux.FullName);
            Console.WriteLine(directorioAux.Name);
            Console.WriteLine(directorioAux.Parent);
            Console.WriteLine(directorioAux.Attributes);
            Console.WriteLine(directorioAux.CreationTime);

            //creo y/o elimino un directorio
            string rutaDirectorio = @"C:\Users\jmallegue\Documents\GitHub\Ejercicios_Csharp\Practicas\Directorio prueba";

            if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            }
            else
            {
                //Directory.Delete(rutaDirectorio);
            }

            #endregion

            #region archivos

            //escribo un array en un archivo
            string[] clientes = { "Jose", "Maria", "Allegue" };
            string rutaArchivo = @"C:\Users\jmallegue\Documents\GitHub\Ejercicios_Csharp\Practicas\Directorio prueba\archivo_prueba.txt";

            File.WriteAllLines(rutaArchivo, clientes);

            //leo el archivo
            foreach(string aux in File.ReadLines(rutaArchivo))
            {
                Console.WriteLine(aux);
            }

            //obtengo todos los archivos que siguen un patron en un directorio y escribo la cantidad que haya
            DirectoryInfo directorioPrueba = new DirectoryInfo(rutaDirectorio);

            FileInfo[] archivosTxt = directorioPrueba.GetFiles("*.txt");

            Console.WriteLine($"Cantidad de .txt: {archivosTxt.Length}");

            foreach(FileInfo archivo in archivosTxt)
            {
                Console.WriteLine(archivo.Name);
                Console.WriteLine(archivo.Length);
            }

            #endregion

            #region fileStream

            //FileStream is used to read and write a byte or an array of bytes. 
             string rutaDirectorio2 = @"C:\Users\jmallegue\Documents\GitHub\Ejercicios_Csharp\Practicas\Directorio prueba\Archivo_FileStream.txt";

            FileStream fileStreamAux = File.Open(rutaDirectorio2, FileMode.OpenOrCreate);

            string texto = "Texto ramdon";

            byte[] textoByteArr = Encoding.Default.GetBytes(texto);

            fileStreamAux.Write(textoByteArr, 0, textoByteArr.Length);

            fileStreamAux.Position = 0;

            byte[] archivoByteArr = new byte[textoByteArr.Length];

            for(int i =0; i < textoByteArr.Length; i++)
            {
                textoByteArr[i] = (byte)fileStreamAux.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(textoByteArr));

            fileStreamAux.Close();

            #endregion

            #region streamWriter/streamReader
            // These are best for reading and writing strings

            string rutaDirectorio3 = @"C:\Users\jmallegue\Documents\GitHub\Ejercicios_Csharp\Practicas\Directorio prueba\archivo_streamWriter.txt";

            StreamWriter streamWriterAux = File.CreateText(rutaDirectorio3);

            streamWriterAux.WriteLine("Hola mundo");
            streamWriterAux.WriteLine("Adios mundo");

            //se tienen que cerrar el archivo para guardarlo
            streamWriterAux.Close();

            StreamReader streamReaderAux = File.OpenText(rutaDirectorio3);

            Console.WriteLine($"Peek: {Convert.ToChar(streamReaderAux.Peek())}");

            //al leer el archivo se eliminan los elementos
            Console.WriteLine($"1 string: {streamReaderAux.ReadLine()}");
            Console.WriteLine($"Todo: {streamReaderAux.ReadToEnd()}");

            streamReaderAux.Close();

            #endregion

            #region binaryWriter/binaryReader

            // Used to read and write data types 
            string rutaDirectorio4 = @"C:\Users\jmallegue\Documents\GitHub\Ejercicios_Csharp\Practicas\Directorio prueba\archivo_binaryWriter.dat";

            // Get the file
            FileInfo archivoDat = new FileInfo(rutaDirectorio4);

            // Open the file
            BinaryWriter binaryWriterAux = new BinaryWriter(archivoDat.OpenWrite());

            // Data to save to the file
            string textoRandom = "Random Text";
            int miEdad = 42;
            double altura = 6.25;

            // Write data to a file
            binaryWriterAux.Write(textoRandom);
            binaryWriterAux.Write(miEdad);
            binaryWriterAux.Write(altura);

            binaryWriterAux.Close();

            // Open file for reading
            BinaryReader binaryReaderAux = new BinaryReader(archivoDat.OpenRead());

            // Output data
            Console.WriteLine(binaryReaderAux.ReadString());
            Console.WriteLine(binaryReaderAux.ReadInt32());
            Console.WriteLine(binaryReaderAux.ReadDouble());

            binaryReaderAux.Close();

            #endregion

        }
    }
}
