using System;
using ejercicio_3.Archivos;
using ejercicio_3.Excepciones;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ejercicio_3.Clases_instanciables
{
    public class Jornada:Texto
    {
        #region campos y atributos

        public List<Alumno> Alumnos { get; set; }
        public Universidad.EClases Clase { get; set; }
        public Profesor Instructor { get; set; }
        
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

        public bool Guardar()
        {
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\jornada.txt");
            bool retorno = false;

            try
            {
               retorno = Guardar(rutaArchivo.FullName, this.ToString());
            }
            catch(ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;
        }

        public string Leer()
        {
            string retorno = default;
            DirectoryInfo rutaArchivo = new DirectoryInfo(@"..\..\..\Archivos\jornada.txt");
            bool resultado = false;

            try
            {
                resultado = Leer(rutaArchivo.FullName, out retorno);
            }
            catch(ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }           

            return retorno;
        }     

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Clase: {Clase.ToString()}").AppendLine();
            retorno.Append($"Profesor:").AppendLine();
            retorno.Append($"{Instructor.ToString()}").AppendLine();
            retorno.Append($"Alumnos:").AppendLine();

            foreach (Alumno alumno in this.Alumnos)
            {
                retorno.Append($"{alumno.ToString()}").AppendLine();
            }

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
