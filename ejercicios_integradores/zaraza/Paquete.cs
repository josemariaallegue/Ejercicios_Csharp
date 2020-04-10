using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace zaraza
{
    class Paquete
    {
        #region campos y propiedades
        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        public string DireccionEntrega { get; set; }
        public string TrackingId { get; set; }
        public EEstado Estado { get; set; }

        #endregion

        #region constructores
        public Paquete(string _direccionEntrega, string _trackingID)
        {
            DireccionEntrega = _direccionEntrega;
            TrackingId = _trackingID;
        }

        #endregion

        #region metodos y sobrecaras

        /// <summary>
        /// MostrarDatos utilizará string.Format con el siguiente formato "{0} para {1}", p._trackingID, p._direccionEntrega
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(Paquete elemento)
        {
            return string.Format($"{elemento.TrackingId} para {elemento.DireccionEntrega}");
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Dos paquetes serán el mismo si su tracking ID es igual.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.TrackingId == p2.TrackingId);
        }

        /// <summary>
        /// Dos paquetes serán distintos si su tracking ID es distinto.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// a.	Colocar una demora de 10 segundos.
        /// b.	Pasar al siguiente estado.
        /// c.	Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra.
        /// d.	Repetir las acciones desde el punto A hasta que el estado sea Entregado.
        /// e.	Finalmente guardar los datos del paquete en la base de datos.
        /// </summary>
        public void MockCicloDeVida()
        {
            //Thread.Sleep(10000);
            Console.WriteLine(this.Estado);
            this.Estado += 1;
            Console.WriteLine(this.Estado);
            this.Estado += 1;
            Console.WriteLine(this.Estado);
            Console.WriteLine("Termino");
        }

        #endregion

    }
}
