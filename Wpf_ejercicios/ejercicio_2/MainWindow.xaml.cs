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
using System.IO;

namespace ejercicio_2
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(var drive in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem();

                item.Header = drive;
                item.Tag = drive;


                item.Expanded += Item_Expanded;

                carpetasView.Items.Add(item);
            }

        }

        private void Item_Expanded(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
