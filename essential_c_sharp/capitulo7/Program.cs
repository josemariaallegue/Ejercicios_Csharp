using System;

namespace capitulo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clase1 = new Class1();
            Class2 clase2 = new Class2();

            //Impicita se pone un punto + el metodo
            clase1.Metodo1();

            //se tiene que castear el objeto al tipo de la interfaz
            ((Interface2)clase1).Metodo2();
        }
    }
}
