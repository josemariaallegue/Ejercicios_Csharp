using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_16
{
    class Alumno
    {
        #region campos

        private int _nota1;
        private int _nota2;
        private int _notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        #endregion

        #region contructores

        public Alumno(string nombre, string apellido, int legajo, int nota1, int nota2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            Estudiar(nota1, nota2);
        }

        #endregion

        #region metodos

        public void CalcularFinal()
        {
            Random random = new Random();

            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal =random.Next(1, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(int notaUno, int notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public string Mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append($"La nota final de {this.nombre} {this.apellido}, legajo {this.legajo} es de {this._notaFinal}");

            return texto.ToString();
        }

        #endregion 


    }
}
