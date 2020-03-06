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

namespace Wpf_demo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nacionalidadComboBox.ItemsSource = Enum.GetValues(typeof(Nacionalidades));
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            Persona persona = new Persona(nombreText.Text, apellidoText.Text, nacionalidadComboBox.Text, Convert.ToInt32(edadText.Text));

            MessageBox.Show($"{persona.Mostrar()}");
        }
    }
}
