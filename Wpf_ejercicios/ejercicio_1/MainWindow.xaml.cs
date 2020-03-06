using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ejercicio_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.descriptionText.Text);
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            this.weldCheck.IsChecked = this.assemblyCheck.IsChecked = this.plasmaCheck.IsChecked = this.laserCheck.IsChecked = this.purchaseCheck.IsChecked =
            this.latheCheck.IsChecked = this.drillCheck.IsChecked = this.foldCheck.IsChecked = this.rollCheck.IsChecked = this.sawCheck.IsChecked =
            false;
        }

        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            if (this.lenghtTextBox.Text == "")
            {
                this.lenghtTextBox.Text = (string)((CheckBox)sender).Content;
            }
            else 
            {
                this.lenghtTextBox.Text = this.lenghtTextBox.Text + "; " + ((CheckBox)sender).Content;
            }
        }
    }
}
