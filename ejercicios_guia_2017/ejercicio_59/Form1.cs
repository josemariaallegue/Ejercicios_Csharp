using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_59
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            productosListBox.DataSource = productos;
            productosListBox.DisplayMember = "FullData";
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            productos =  DataBaseAcceso.ObtenerProductos(IdBuscarTextBox.Text);
            
            if(productos.Count==0)
            {
                productos = null;
                productosListBox.DataSource = productos;
                productosListBox.DisplayMember = "FullData";
            }
            else if(productos.Count > 0)
            {
                productosListBox.DataSource = productos;
                productosListBox.DisplayMember = "FullData";
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            DataBaseAcceso.AgregarProducto(nombreAgregarTextBox.Text, cantidadAgregarTextBox.Text, precioAgregarTextBox.Text, pesoAgregarTextBox.Text);
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            DataBaseAcceso.ModificarProducto(idModificarTextBox.Text, nombreModificarTextBox.Text, cantidadModificarTextBox.Text, precioModificarTextBox.Text
                , pesoModificarTextBox.Text);
        }
    }
}
