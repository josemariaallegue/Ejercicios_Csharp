using ejercicio_4.Excepciones;
using ejercicio_4.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ejercicio_4.Clases
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region campos y propiedades

        private List<Thread> _mockPaquetes;

        public List<Paquete> Paquetes { get; set; }

        #endregion

        #region constructores

        public Correo()
        {
            Paquetes = new List<Paquete>();
            _mockPaquetes = new List<Thread>();
        }

        #endregion

        #region metodos y sobrecargas

        /// <summary>
        /// Utilizará string.Format con el siguiente formato "{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()
        /// para retornar los datos de todos los paquetes de su lista
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder retorno = new StringBuilder();

            foreach (Paquete paqueteAux in ((Correo)elementos).Paquetes)
            {
                retorno.Append($"{paqueteAux.TrackingId} para {paqueteAux.DireccionEntrega} ({paqueteAux.Estado.ToString()})").AppendLine();
            }

            return retorno.ToString();
        }

        /// <summary>
        /// a.	Controlar si el paquete ya está en la lista. En el caso de que esté, se lanzará la excepción TrackingIdRepetidoException.
        /// b.	Agregar el paquete a la lista de paquetes.
        /// c.	Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes.
        /// d.	Ejecutar el hilo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            bool ingresado = false;

            if (!(c.Paquetes is null))
            {
                foreach (Paquete paqueteaux in c.Paquetes)
                {
                    if (paqueteaux == p)
                    {
                        ingresado = true;
                        throw new TrackingIdRepetidoException("El paquete ya esta ingresado");
                    }
                }
            }

            if (!ingresado)
            {
                c.Paquetes.Add(p);
                Thread ciclo = new Thread(p.MockCicloDeVida);
                ciclo.Start();
                c._mockPaquetes.Add(ciclo);
            }

            return c;
        }

        /// <summary>
        /// Cerrará todos los hilos ACTIVOS
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread ciclo in this._mockPaquetes)
            {
                ciclo.Abort();
            }
        }

        #endregion
    }
}
