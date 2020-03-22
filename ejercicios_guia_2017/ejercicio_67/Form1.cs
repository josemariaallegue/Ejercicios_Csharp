using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_67
{
    public partial class Form1 : Form
    {
        #region propiedades

        public Persona PersonaAux { get; set; }
        public event Persona.DelegadoString mostrarDatosEvento;

        #endregion

        #region metodos

        public static void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarDatosEvento += Form1_mostrarDatosEvento;
        }

        private void Form1_mostrarDatosEvento(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            if(PersonaAux is null)
            {
                PersonaAux = new Persona(nombreTextBox.Text, apellidoTextBox.Text);
                crearButton.Text = "Actualizar";
                mostrarDatosEvento?.Invoke("Persona creada");
                MessageBox.Show(PersonaAux.Mostrar());

            }
            else
            {
                if(PersonaAux.Nombre != nombreTextBox.Text && PersonaAux.Apellido == apellidoTextBox.Text)
                {
                    mostrarDatosEvento?.Invoke("Nombre cambiado");

                }
                else if(PersonaAux.Nombre == nombreTextBox.Text && PersonaAux.Apellido != apellidoTextBox.Text)
                {
                    mostrarDatosEvento?.Invoke("Apellido cambiado");
                }
                else if(PersonaAux.Nombre != nombreTextBox.Text && PersonaAux.Apellido != apellidoTextBox.Text)
                {
                    mostrarDatosEvento?.Invoke("Nombre y apellido cambiado");
                }
                else
                {
                    mostrarDatosEvento?.Invoke("Nada se ha cambiado");
                }

                PersonaAux = null;
                PersonaAux = new Persona(nombreTextBox.Text, apellidoTextBox.Text);
                                MessageBox.Show(PersonaAux.Mostrar());

            }
        }
    }
}
