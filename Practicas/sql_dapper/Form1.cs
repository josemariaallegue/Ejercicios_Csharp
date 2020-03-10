using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_dapper
{
    public partial class personasWindow : Form
    {
        List<Persona> listaPersonas = new List<Persona>(); 
        public personasWindow()
        {
            InitializeComponent();
            personasList.DataSource = listaPersonas;
            personasList.DisplayMember = "FullData";
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            
            DataAcces data = new DataAcces();

            listaPersonas =  data.ObtenerPersona(apellidoText.Text);
            if(listaPersonas.Count == 0)
            {
                listaPersonas.Clear();
                personasList.DataSource = listaPersonas;
            }
            else
            {
                personasList.DataSource = listaPersonas;
                personasList.DisplayMember = "FullData";
            }
            
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DataAcces data = new DataAcces();

            data.AgregarPersona(idAgregarText.Text, nombreAgregarText.Text, apellidoAgregarText.Text, nacionalidadAgregarText.Text);
        }
    }
}
