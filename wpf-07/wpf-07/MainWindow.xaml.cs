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

namespace wpf_07
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    // COMO SE VINCULA EL LABEL A UN TEXTBOX Y QUE SE COMPORTE COMO UN SHORTCUT DE DELPHI &
    // OJO QUE LOS LABEL DEBE DE TENER LOS BINDING Y DEBE DE TENER TAMBIEN EL LABEL COMO NOMBRE
    // PRIMERO UN GUION BAJO Y DESPUES LO QUE SE QUIERA 
    // EN EL BINDING SE PONE EL NOMBRE DEL TEXTBOX


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMensaje_Click(object sender, RoutedEventArgs e)
        {
            LabMensaje.Content = "Saludo desgraciado";
        }
    }
}
