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

namespace WpfApp_16
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

        private void btnMensaje_Click(object sender, RoutedEventArgs e)
        {
            //  MessageBox.Show("Hola a todos");
            //MessageBox.Show("Hola a todos", "SALUDO");
            //  MessageBox.Show("", "", MessageBoxButton.OK);

            // Tipo de botones:
            // OK, OKCancel, YesNoCancel, YesNo
            // o sea:
            // MessageBoxButton.OK
            // MessageBoxButton.YesNoCancel

            //MessageBoxResult seleccion = MessageBox.Show("Te gusta el jamón", "PREGUNTA", MessageBoxButton.YesNoCancel);

            //switch (seleccion)
            //{
            //    case MessageBoxResult.Yes:
            //        MessageBox.Show("ha pulsado sí");
            //        break;
            //    case MessageBoxResult.No:
            //        MessageBox.Show("ha pulsado no");
            //        break;
            //    case MessageBoxResult.Cancel:
            //        MessageBox.Show("ha pulsado cancelar");
            //        break;

            //}


            //AQUI ES INCORPORACIÓN DE UNA IMAGEN AL MESSAGEBOX
            // SERÍA
            // MessageBoxImage.Question => PARA UN INTERROGANTE
            // MessageBoxImage.Exclamation => PARA EXCLAMACION
            // MessageBoxImage.Error => PARA INDICAR ERROR
            // MessageBoxImage.Information => PARA INFORMACION
            //    MessageBoxImage.Warning => PARA ADVERTENCIA

            //           MessageBox.Show("Hola a todos", "desde mi aplicación",MessageBoxButton.YesNo, MessageBoxImage.None);


            // AQUI DESPUES DE TODO LO ANTERIOR, ADEMÁS PONEMOS UN BOTÓN POR DEFECTO QUE SERÁ EL QUE ESTÉ PRESELECCIONADO
            // EN EL SIGUIENTE CASO ES EL DE YES EL QUE ESTÁ PRESECCIONADO

            MessageBoxResult seleccion = MessageBox.Show("Hola a todos", "desde mi aplicación", MessageBoxButton.YesNoCancel, MessageBoxImage.Hand, MessageBoxResult.Yes);

            if (seleccion == MessageBoxResult.Yes)
            {
                MessageBox.Show("ha pulsado sí");
            }


        }
    }
}
