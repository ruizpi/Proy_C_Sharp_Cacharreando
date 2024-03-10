using Microsoft.Win32;
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

namespace WpfApp_12
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

        private void BtnCargar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.Filter = "Images files | *.jpg;*.gif";

            if (ventana.ShowDialog() == true)
            {
                Uri fileUri = new Uri(ventana.FileName);
                Img.Source = new BitmapImage(fileUri);
            }



        }
    }
}
