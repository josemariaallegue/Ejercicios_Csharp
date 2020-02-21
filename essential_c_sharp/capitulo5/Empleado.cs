using System;
using System.Collections.Generic;
using System.Text;

namespace capitulo5
{
    class Empleado
    {
        #region campos

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _salario;
        private int _edad;
        private static int _cantidadEmpleados;

        /*readonly
         permite que un campo sea de solo lectura. Solo se puede modificar desde un constructor o con un initializer 
         durante la declaracion*/
        private readonly int documento;

        #endregion

        #region constructores

        //permiten inicializar el objeto en el momento de la creacion del objeto

        /*default constructor
        si no existen ningun contructor creado el compilar creado uno que inicializado todos las variables 
        a su valor por default. Cuando se crea cualquier contructor el compilar no crea el suyo, por lo que se tiene
        que crear uno. 
        Es util para inicializar las variables con algun valor predeterminando*/
        public Empleado()
        {
            this.Id = _cantidadEmpleados;
            _cantidadEmpleados++;
            this.Nombre = "Jonh";
            this.Apellido = "Doe";
            this.Salario = "Nothing";
            this.Edad = 0;
            this.documento = 00000000;
        }

        public Empleado(string nombre, string apellido, int documento)
        {
            this.Id = CantidadEmpleados;
            _cantidadEmpleados++;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.documento = documento;
        }

        /*constructor chaining
         permite eliminar duplicacion de codigo al llamar a otro contructor que ya tiene los parametros que 
         se piden*/
        public Empleado(string nombre, string apellido, string salario, int edad, int documento):
            this(nombre, apellido, documento)
        {
            this.Salario = salario;
            this.Edad = edad;
        }

        /*Constructor estatico
         No toman parametros y se ejecutan a penas la clase en mencionada
         Los campos estaticos se pueden inicializar en la declarion pero es mejor hacerlo con un contructor por 
         si se quieren hacer validacion o mas operaciones*/
        static Empleado()
        {
            CantidadEmpleados = 0;
        }

        #endregion

        #region propiedades

        //propiedades (getters y setters) buscar mas informacion respecto a la syntaxis
        //permite acceder a los campos privados del objeto

        //nueva sintaxis de las propiedades. Preferible si no hay validaciones en la propiedad
        public string Nombre
        {
            get => this._nombre;
            /*al poner el private hace que solo se pueda setear dentro del la clase, por lo que lo convierte en una 
             propiedad de solo lectura*/
            private set => this._nombre = value;
        }

        //vieja sixtaxis de las propiedades. Preferible si hay validaciones en la propiedad
        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {   
                if((value == null) || (value.Trim() == ""))
                {
                    //zaraza
                }
                else
                {
                    this._apellido = value;
                }
                
            }
        }

        public string Salario
        {
            get => this._salario;
            set => this._salario = value;
        }

        public int Edad
        {
            get => this._edad;
            set => this._edad = value;
        }

        public int Id
        {
            get => this._id;
            set => this._id = value;
        }

        public static int CantidadEmpleados
        {
            get => _cantidadEmpleados;
            set => _cantidadEmpleados = value;
        }

        public int Documento
        {
            get => this.documento;
        }

        //forma de hacer la declaracion y la propiedad en la misma linea. Tambien se puede hacer la asignacion
        public string titulo { get; set; } = "Nerd";

        #endregion

    }
}
