using ejercicio_4.Clases;
using ejercicio_4.Clases_estaticas;
using ejercicio_4.Excepciones;
using ejercicio_4.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class FrmPpal : Form
    {
        #region campos y propiedades

        private Correo correo = new Correo();
        private DirectoryInfo directorio = new DirectoryInfo(@"..\..\Archivos\salida.txt");

        #endregion

        #region constructores

        public FrmPpal()
        {
            InitializeComponent();

        }

        #endregion

        #region metodos y sobrecargas

        /// <summary>
        /// Muestro la información de todos los paquetes del correo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion(correo);
        }

        /// <summary>
        /// Muestro la información de un paquete en particular de la lista de Entregados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion((Paquete)lstEstadoEntregado.SelectedItem);
        }

        /// <summary>
        /// Mostrará la información del elemento en RichTextBox rtbMostrar
        /// y utilizará el método de extensión para guardar el texto en this.rtbMostrar.Text
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!object.ReferenceEquals(elemento, null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);

                this.rtbMostrar.Text.Guardar(directorio.FullName);

            }
        }

        /// <summary>
        /// Al cerrarse el formulario, termino todos los hilos en ejecución.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            paquete.InformaEstado += paq_InformaEstado;
            try
            {
                correo += paquete;
            }
            catch (TrackingIdRepetidoException exc)
            {
                Console.WriteLine(exc.Message);
            }
            ActualizarEstados();
        }

        /// <summary>
        /// Si se produce un cambio de estado, actualizo todos los estados de los paquetes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });

            }
            else
            {
                ActualizarEstados();
            }

        }

        /// <summary>
        /// Comprueba y actualiza los estados de envio de los paquetes,
        /// colocando cada paquete en el ListBox correspondiente.
        /// </summary>
        private void ActualizarEstados()
        {
            // Limpio las listas
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete item in correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }

        #endregion
    }
}
