using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace ejercicio_3.Clases_instanciables
{
    public class Jornada
    {
        #region campos y atributos

        public List<Alumno> Alumnos { get; private set; }
        public Universidad.EClases Clase { get; private set; }
        public Profesor Instructor { get; private set; }
        
        #endregion

        #region constructores

        private Jornada()
        {
            Alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
            :this()
        {
            Clase = clase;
            Instructor = instructor;
        }

        #endregion

        #region metodos y sobrecargas

        public string Leer()
        {
            Jornada jornadaAux = null;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\jornada.txt");
            XmlSerializer serializador = new XmlSerializer(typeof(Jornada));

            if (File.Exists(rutaArchivo.FullName))
            {
                using (TextReader reader = new StreamReader(rutaArchivo.FullName))
                {
                    jornadaAux = (Jornada)serializador.Deserialize(reader);
                }
            }           

            return jornadaAux.ToString();
        }

        public bool Guardar(Jornada jornada)
        {
            bool retorno = false;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\jornada.txt");
            XmlSerializer serializador = new XmlSerializer(typeof(Jornada));

            if (File.Exists(rutaArchivo.FullName))
            {
                using (TextWriter writer = new StreamWriter(rutaArchivo.FullName))
                {
                    serializador.Serialize(writer, jornada);
                    retorno = true;
                }
            }            

            return retorno;

        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Clase: {Clase.ToString()}").AppendLine();
            retorno.Append($"Profesor: {Instructor.ToString()}").AppendLine();
            retorno.Append($"Alumnos:").AppendLine();

            foreach (Alumno alumno in this.Alumnos)
            {
                retorno.Append($"{alumno.ToString()}").AppendLine();
            }

            retorno.AppendLine();

            return retorno.ToString();
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            foreach(Alumno alumno in j.Alumnos)
            {
                if(alumno == a)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static bool operator +(Jornada j, Alumno a)
        {
            bool retorno = false;

            if(j != a)
            {
                j.Alumnos.Add(a);
                retorno = true;
            }

            return retorno;
        }

        #endregion
    }
}
