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

namespace WPF_8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    // EN ESTE EJERCICIO LO QUE SE VE ES COMO UN TEXTBOX PUEDE TENER MULTIPLES LINEAS 
    // DE TEXTO Y AL SELECCIONAR UNA DE ESAS LINEAS SE PUEDE OBTENER ESA PARTE PARCIAL DE TEXTO
    // PARA INDICARLE AL TEXTBOX QUE PUEDE TENER MULTIPLES LINEAS HAY QUE PONER
    // AcceptsReturn="True" EN XAML



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMensaje_Click(object sender, RoutedEventArgs e)
        {
            string mensaje = "Hola " + EdTexto01.Text;
            TxtBlock.Text = mensaje;


        }

        private void BotLimpiar_Click(object sender, RoutedEventArgs e)
        {
            EdTexto02.Text = "Escribe";
        //    EdTexto02.Clear();
        }

        private void BotSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            string textoSel = EdTexto02.SelectedText;
            TxtBlock.Text = textoSel;
        }
    }
}
