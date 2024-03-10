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
using System.Windows;

namespace WPF_02
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Boton2.Click += Segundo_Click;
            Boton2.Click += new RoutedEventHandler(Segundo_Click);
        }

        private void Boton1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has oprimido este boton 1");
        }

        private void Segundo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has oprimido este boton 2");
        }


    }
}
