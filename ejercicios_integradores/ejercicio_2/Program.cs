﻿using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region prueba original

            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2);

            Changuito changoDeCompras = new Changuito(6);

            Dulce c1 = new Dulce(Dulce.EMarca.Sancor, "ASD012", ConsoleColor.Black);
            Dulce c2 = new Dulce(Dulce.EMarca.Ilolay, "ASD913", ConsoleColor.Red);
            Leche m1 = new Leche(Leche.EMarca.Pepsico, "HJK789", ConsoleColor.White);
            Leche m2 = new Leche(Leche.EMarca.Serenisima, "IOP852", ConsoleColor.Blue, Leche.ETipo.Descremada);
            Snacks a1 = new Snacks(Snacks.EMarca.Campagnola, "QWE968", ConsoleColor.Gray);
            Snacks a2 = new Snacks(Snacks.EMarca.Arcor, "TYU426", ConsoleColor.DarkBlue);
            Snacks a3 = new Snacks(Snacks.EMarca.Sancor, "IOP852", ConsoleColor.Green);
            Snacks a4 = new Snacks(Snacks.EMarca.Sancor, "TRE321", ConsoleColor.Green);

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            changoDeCompras += c1;
            changoDeCompras += c2;
            changoDeCompras += m1;
            changoDeCompras += m1;
            changoDeCompras += m2;
            changoDeCompras += a1;
            changoDeCompras += a2;
            changoDeCompras += a3;
            changoDeCompras += a4;

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Quito un item y muestro
            changoDeCompras -= c1;
            changoDeCompras -= new Dulce(Producto.EMarca.Ilolay, "ASD913", ConsoleColor.Red);

            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Vuelvo a agregar c2
            changoDeCompras += c2;

            // Muestro solo Dulces
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Dulce));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Leches
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Leche));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Snacks
            Console.WriteLine(Changuito.Mostrar(changoDeCompras, Changuito.ETipo.Snacks));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey();

            #endregion
        }
    }
}
