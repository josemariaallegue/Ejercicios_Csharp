﻿using System;

namespace ejercicio_36
{
    class Program
    {


        static void Main(string[] args)
        {
            MotoCross moto1 = new MotoCross(100, "Alfa", 100);
            MotoCross moto2 = new MotoCross(100, "Alfa", 200);
            AutoF1 auto1 = new AutoF1(100, "Alfa", 200);
            VehiculoDeCarrera vehiculo1 = new VehiculoDeCarrera(100, "Alfa");
            VehiculoDeCarrera vehiculo2 = new VehiculoDeCarrera(100, "Alfa");
            Competencia competencia1 = new Competencia(100, 10, TipoCompetencia.MotoCross);

            Console.WriteLine(competencia1 + moto1);
            
        }
    }
}
