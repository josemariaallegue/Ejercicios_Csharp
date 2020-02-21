using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            float horasMensuales = 0;
            string nombre, respuesta;
            int antiguedad = 0;
            double empleados, importe;
            bool continuar = true;

            valorHora = 9;
            respuesta = "Y";

            while(continuar)
            {
                switch (respuesta)
                {
                    case "Y":
                        //cargo los datos del empleado
                        horasMensuales = 100;
                        nombre = "José Maria Allegue";
                        antiguedad = 10;

                        importe = (valorHora * horasMensuales + antiguedad * 150) * 0.87;

                        //imprimo en pantalla
                        Console.Clear();
                        Console.WriteLine($"El sueldo bruto de {nombre} es {importe}");

                        //continuo o no
                        Console.WriteLine("Desea agregar otro empleado? Y/N");
                        respuesta = Console.ReadLine().ToUpper();
                        break;

                    case "N":
                        continuar = false;
                        break;

                    default:
                           
                        Console.Clear();
                        Console.WriteLine("Valor ingresado no valido");
                        Console.WriteLine("Desea agregar otro empleado? Y/N");
                        respuesta = Console.ReadLine().ToUpper();
                        break;
                }

            }
        }
    }
}
