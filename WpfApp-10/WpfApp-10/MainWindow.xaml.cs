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

namespace WpfApp_10
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

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double a = Double.Parse(EdA.Text);
            double b = Double.Parse(EdB.Text);

            double r = 0;

            if (RBSuma.IsChecked == true)
            {
                r = a + b;
            }

            if (RBResta.IsChecked == true)
            {
                r = a + b;
            }

            if (RBMulti.IsChecked == true)
            {
                r = a + b;
            }

            if (RBDividir.IsChecked == true)
            {
                r = a / b;
            }

            TxtBlockResultado.Text = r.ToString();


        }
    }
}
