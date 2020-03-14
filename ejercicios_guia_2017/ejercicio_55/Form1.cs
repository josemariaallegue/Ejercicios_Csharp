using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ejercicio_55
{
    public partial class Form1 : Form
    {
        #region campos
        public string Archivo { get; set; }
        #endregion
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel.Text = "";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = @"..\..\",
                RestoreDirectory = true,
                Title = "Busca el archivo a abrir",
                CheckFileExists = true,
                CheckPathExists = true


            };

            if(open.ShowDialog() == DialogResult.OK)
            {
                Archivo = open.FileName;
                richTextBox.Text = File.ReadAllText(open.FileName);
            }           

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Archivo, richTextBox.Text);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                InitialDirectory = @"..\..\",
                RestoreDirectory = true,
                Title = "Busca el archivo a Guardar",

            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(save.FileName))
                {
                    File.WriteAllText(save.FileName, richTextBox.Text);
                }
                else
                {

                    using (StreamWriter writer = File.CreateText(save.FileName))
                    {
                        writer.Write(richTextBox.Text);                      
                    }                        

                }
                
            }

            Archivo = save.FileName;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"{Convert.ToString(richTextBox.TextLength)} caracteres";
        }

        
    }
}
