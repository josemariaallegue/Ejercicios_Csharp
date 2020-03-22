using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class calculadoraForm : Form
    {

        Numero numero1 = null;
        Numero numero2 = null;
        Calculadora calculadora = new Calculadora();
        string[] operadoresValidos = { "+", "-", "/", "*" };

        public calculadoraForm()
        {
            InitializeComponent();
            operadorComboBox.Items.AddRange(operadoresValidos);
        }

        private void operarButton_Click(object sender, EventArgs e)
        {
            numero1 = new Numero(numero1TextBox.Text);
            numero2 = new Numero(numero2TextBox.Text);
            resultadoLabel.Text = Convert.ToString(calculadora.Operar(numero1, numero2, operadorComboBox.Text));
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            numero1TextBox.Text = "";
            numero2TextBox.Text = "";
            operadorComboBox.Text = "";
            resultadoLabel.Text = "";
        }

        private void aBinarioButton_Click(object sender, EventArgs e)
        {
            if(resultadoLabel.Text != "")
            {
                resultadoLabel.Text = Numero.DecimalBinario(Convert.ToDouble(resultadoLabel.Text));
            }
            else
            {
                MessageBox.Show("Imposible hacer la operacion porque la etiqueta de resultado esta vacia");
            }           
           
        }

        private void aDecimalButton_Click(object sender, EventArgs e)
        {
            if(resultadoLabel.Text != "")
            {
                resultadoLabel.Text = Convert.ToString(Numero.BinarioDecimal(resultadoLabel.Text));
            }
            else
            {
                MessageBox.Show("Imposible hacer la operacion porque la etiqueta de resultado esta vacia");
            }            
        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
