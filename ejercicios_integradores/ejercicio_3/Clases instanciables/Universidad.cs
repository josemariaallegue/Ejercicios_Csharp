using System;
using System.Collections.Generic;
using System.Text;
using ejercicio_3.Excepciones;
using ejercicio_3.Archivos;
using System.IO;
using System.Xml.Serialization;

namespace ejercicio_3.Clases_instanciables
{
    public class Universidad : Xml<Universidad>
    {
        #region campos y atributos

        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }
        public List<Alumno> Alumnos { get; private set; }
        public List<Profesor> Instructores { get; private set; }
        public List<Jornada> Jornadas { get; private set; }
        public Jornada this[int i]
        {
            get
            {
                return Jornadas[i];
            }

            set
            {
                Jornadas[i] = value;
            }
        }


        #endregion

        #region constructores

        public Universidad()
        {
            Alumnos = new List<Alumno>();
            Instructores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }

        #endregion

        #region metodos y sobrecargas

        private string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine();
            retorno.Append($"Jornadas:").AppendLine();
            foreach (Jornada jornada in Jornadas)
            {
                retorno.AppendLine();
                retorno.Append(jornada.ToString());
                retorno.Append($"<------------------------------------------------->").AppendLine();
            }
            retorno.AppendLine();

            return retorno.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public bool Guardar()
        {
            bool retorno = false;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\universidad.txt");

            try
            {
                retorno =  Guardar(rutaArchivo.FullName, this);
            }
            catch(ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno; 
        }

        public string Leer()
        {
            Universidad universidadAux = default;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\universidad.txt");
            bool resultado = false;

            try
            {
               resultado = Leer(rutaArchivo.FullName, out universidadAux);
            }
            catch(ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }                
            
            return universidadAux.ToString();
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    retorno = true;
                }
            }            

            return retorno;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor p)
        {
            bool retorno = false;

            foreach (Profesor profesor in g.Instructores)
            {
                if (profesor == p)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Profesor p)
        {
            return !(g == p);
        }

        public static Profesor operator ==(Universidad g, EClases clase)
        {
            
            foreach(Profesor profesor in g.Instructores)
            {
                if(profesor == clase)
                {
                    return profesor;
                }
            }

            throw new SinProfesorException();

        }

        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor profesor in g.Instructores)
            {
                if (profesor != clase)
                {
                    return profesor;
                }
            }

            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad g, Alumno a)
        {
            if(g != a)
            {
                g.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return g;
        }

        public static Universidad operator +(Universidad g, Profesor p)
        {
            if(g != p)
            {
                g.Instructores.Add(p);
            }

            return g;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesorAux = default;
            Jornada jornadaAux = default;
            bool resultado = false;

            profesorAux = g == clase;

            jornadaAux = new Jornada(clase, profesorAux);

            foreach(Alumno alumno in g.Alumnos)
            {
                if(alumno == clase)
                {
                    resultado = jornadaAux + alumno;
                }
            }

            g.Jornadas.Add(jornadaAux);

            return g;
        }

        #endregion

    }
}
