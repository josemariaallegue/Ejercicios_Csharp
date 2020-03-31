using System;
using System.Collections.Generic;
using System.Text;
using ejercicio_3.Excepciones;
using System.IO;
using System.Xml.Serialization;

namespace ejercicio_3.Clases_instanciables
{
    public class Universidad
    {
        #region campos y atributos

        public enum EClases { Porgramacion, Laboratorio, Legislacion, SPD}
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

        }

        #endregion

        #region metodos y sobrecargas

        private string MostrarDatos()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Guardar(Universidad uni)
        {
            bool retorno = false;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\universidad.txt");
            XmlSerializer serializador = new XmlSerializer(typeof(Universidad));

            if (File.Exists(rutaArchivo.FullName))
            {
                using (TextWriter writer = new StreamWriter(rutaArchivo.FullName))
                {
                    serializador.Serialize(writer, this);
                    retorno = true;
                }
            }

            return retorno;

        }

        public string Leer()
        {
            Universidad universidadAux = null;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\universidad.txt");
            XmlSerializer serializador = new XmlSerializer(typeof(Universidad));

            if (File.Exists(rutaArchivo.FullName))
            {
                using (StreamReader reader = new StreamReader(rutaArchivo.FullName))
                {
                    universidadAux = (Universidad)serializador.Deserialize(reader);
                }
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
            Profesor profesorAux = null;
            Jornada jornadaAux = null;
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
