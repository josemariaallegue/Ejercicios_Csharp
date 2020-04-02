using System;
using ejercicio_3.Clases_instanciables;
using ejercicio_3.Excepciones;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo la universidad y el primer alumno. Agrego el alumno a la universidad
            Universidad universidad = new Universidad();
            Alumno alumno1 = new Alumno(100, "Jose", "Allegue", "37098117", Clases_abstractas.Persona.ENacionalidad.Argentino,
                Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);

            universidad += alumno1;

            //pruebo la validacion de dni
            try
            {
                Alumno alumno2 = new Alumno(2, "Juana", "Martinez", "12234458",
               Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);
                universidad += alumno2;
            }
            catch (NacionalidadInvalidaException e)
            {
                Console.WriteLine(e.Message);
            }

            //pruebo la verificacion de alumnos repetidos
            try
            {
                Alumno alumno3 = new Alumno(3, "José", "Gutierrez", "37098117",
               Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
               Alumno.EEstadoCuenta.Becado);
                universidad += alumno3;
            }
            catch (AlumnoRepetidoException e)
            {
                Console.WriteLine(e.Message);
            }

            //creo mas alumnos y los agrego
            Alumno alumno4 = new Alumno(4, "Miguel", "Hernandez", "92264456",
            Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion,
            Alumno.EEstadoCuenta.AlDia);
            universidad += alumno4;
            Alumno alumno5 = new Alumno(5, "Carlos", "Gonzalez", "12236456",
           Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
           Alumno.EEstadoCuenta.AlDia);
            universidad += alumno5;
            Alumno alumno6 = new Alumno(6, "Juan", "Perez", "12234656",
           Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio,
           Alumno.EEstadoCuenta.Deudor);
            universidad += alumno6;
            Alumno alumno7 = new Alumno(7, "Joaquin", "Suarez", "91122456",
           Clases_abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
           Alumno.EEstadoCuenta.AlDia);
            universidad += alumno7;
            Alumno alumno8 = new Alumno(8, "Rodrigo", "Smith", "22236456",
           Clases_abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion,
           Alumno.EEstadoCuenta.AlDia);
            universidad += alumno8;

            //creo 2 profesores y los agrego a la universdad
            Profesor profesor1 = new Profesor(1, "Juan", "Lopez", "12234456",
            Clases_abstractas.Persona.ENacionalidad.Argentino);
            universidad += profesor1;
            Profesor profesor2 = new Profesor(2, "Roberto", "Juarez", "32234456",
           Clases_abstractas.Persona.ENacionalidad.Argentino);
            universidad += profesor2;

            //prueba de agregar clases a la universidad
            try
            {
                universidad += Universidad.EClases.Programacion;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                universidad += Universidad.EClases.Laboratorio;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                universidad += Universidad.EClases.Legislacion;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                universidad += Universidad.EClases.SPD;
            }
            catch (SinProfesorException e)
            {
                Console.WriteLine(e.Message);
            }
            
            //muestro todos los datos de la universidad
            Console.WriteLine(universidad.ToString());

            try
            {
                universidad.Guardar();
                Console.WriteLine("Archivo de Universidad guardado.");
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                int numeroJornada = 0;
                universidad[numeroJornada].Guardar();
                Console.WriteLine($"Archivo de Jornada {numeroJornada} guardado.");
                //Console.WriteLine(Jornada.Leer());
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
