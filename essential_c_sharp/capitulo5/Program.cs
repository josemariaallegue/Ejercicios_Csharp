using System;
using System.Collections.Generic;

namespace capitulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Object initializers
             Permite inicializar alguna variable luego de utilizar el contructor.
             Lo unico que hay que hacer es llamar al setter o variable (tienen que ser publicas para que
             funcionen) entre {} luego del contructor.*/
            Empleado empleado1 = new Empleado() { Edad = 19 };
            var empleados = new List<Empleado>();

            Console.WriteLine("Fin");

            


        }
    }
}
