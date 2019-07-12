using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;


        public Alumno(string apellido, string nombre, int legajo, byte nota1, byte nota2)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
            this._nota1 = nota1;
            this._nota2 = nota2;
        }

        public void CalcularFinal()
        {
            if (_nota1 >= 4 && _nota2 >= 4)
            {
                Random numeroAleatorio = new Random(Guid.NewGuid().GetHashCode());

                this._notaFinal = numeroAleatorio.Next(0,10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void mostrar()
        {
            StringBuilder texto = new StringBuilder();

            texto.AppendFormat("Apellido: {0}, Nombre: {1}, Legajo: {2}, Nota final {3}", this.apellido, this.nombre, this.legajo, this._notaFinal);
            
            Console.WriteLine(texto);
        }

    }
}
