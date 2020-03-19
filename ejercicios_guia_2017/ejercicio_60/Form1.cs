using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_60
{
    public partial class Form1 : Form
    {
        List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
            personasListBox.DataSource = personas;
            personasListBox.DisplayMember = "FullData";
        }

        private void leerButton_Click(object sender, EventArgs e)
        {
            personas = PersonaDAO.Leer(idTextBox.Text);

            if (personas != null && personas.Count > 0 )
            {
                personasListBox.DataSource = personas;
                personasListBox.DisplayMember = "FullData";
            }
            else
            {
                personas = null;
                personasListBox.DataSource = personas;
                personasListBox.DisplayMember = "FullData";
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            Persona personaAux = new Persona(nombreTextBox.Text, apellidoTextBox.Text, nacionalidadTextBox.Text);

            PersonaDAO.Guardar(personaAux);
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            PersonaDAO.Borrar(idTextBox.Text);
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(Convert.ToInt32(idTextBox.Text), nombreTextBox.Text, apellidoTextBox.Text, nacionalidadTextBox.Text);

            PersonaDAO.Modificar(persona);

        }

        private void idTextBox_Leave(object sender, EventArgs e)
        {
            int idAux;

            if (!int.TryParse(idTextBox.Text, out idAux) && idTextBox.Text != "" && idTextBox.Text != "*")
            {
                MessageBox.Show("El id ingresado no es valido.\nEl campo solo puede contener numeros o *.");
                idTextBox.Text = "";
            }
        }

        private void personasListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Persona personaAux = null;

            if(personasListBox.SelectedItem != null)
            {
                personaAux = (Persona)personasListBox.SelectedItem;

                idTextBox.Text = Convert.ToString(personaAux.Id);
                nombreTextBox.Text = personaAux.Nombre;
                apellidoTextBox.Text = personaAux.Apellido;
                nacionalidadTextBox.Text = personaAux.Nacionalidad;
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nombreTextBox.Text = "";
            apellidoTextBox.Text = "";
            nacionalidadTextBox.Text = "";

            personas = null;
            personasListBox.DataSource = personas;
            personasListBox.DisplayMember = "FullData";
        }
    }
}
