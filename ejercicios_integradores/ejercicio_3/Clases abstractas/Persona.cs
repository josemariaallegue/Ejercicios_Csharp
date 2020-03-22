using System;
using System.Collections.Generic;
using System.Text;
using ejercicio_3.Excepciones;
using System.Text.RegularExpressions;

namespace ejercicio_3.Clases_abstractas
{
    public abstract class Persona
    {
        #region campos y atributos

        private string _nombre;
        private string _apellido;
        private int _dni;

        public enum ENacionalidad { Argentino, Extranjero}
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            private set
            {
                _nombre = ValidarNombreApellido(value);
            }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            private set
            {
                _apellido = ValidarNombreApellido(value);
            }
        }
        public int Dni 
        {
            get
            {
                return _dni;
            }
            private set
            {
                _dni = ValidarDni(Nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad { get; private set; }
        public string ToDni
        {
            set
            {
                _dni = ValidarDni(Nacionalidad, value);
            }
        }

        #endregion

        #region constructores

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
            :this()
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            ToDni = dni;
        }

        #endregion

        #region metodos y sobrecargas

        public int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if(dato < 1 || dato > 89999999)
                    {
                        throw new NacionalidadInvalidaException($"DNI argentino menor a 1 o mayor a 89999999");
                    }
                    break;

                case ENacionalidad.Extranjero:
                    if (dato < 90000000 || dato > 99999999)
                    {
                        throw new NacionalidadInvalidaException($"DNI extranjer menor a 90000000 o mayor a 99999999");
                    }
                    break;

                default:
                    throw new NacionalidadInvalidaException();
                    break;
            }

            return dato;
        }

        public int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno;

            if(dato.Length > 8)
            {
                throw new DniInvalidoException("El dni tiene mas de 8 caracteres");
            }
            else if(!int.TryParse(dato, out retorno))
            {
                throw new DniInvalidoException("El dni contiene caracteres no permitidos");
            }
            
            return ValidarDni(nacionalidad  , retorno);
        }

        public string ValidarNombreApellido(string dato)
        {
            string retorno = dato;
            
            if(!Regex.Match(dato, "^[A-Z][a-zA-Z]*$").Success)
            {
                retorno = null;
            }

            return retorno;
        }


        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"Nombre: {Nombre}").AppendLine();
            retorno.Append($"Apellido: {Apellido}").AppendLine();
            retorno.Append($"Dni: {Dni}").AppendLine();
            retorno.Append($"Nacionalidad: {Nacionalidad}").AppendLine();

            return retorno.ToString();
        }

        #endregion
    }
}
