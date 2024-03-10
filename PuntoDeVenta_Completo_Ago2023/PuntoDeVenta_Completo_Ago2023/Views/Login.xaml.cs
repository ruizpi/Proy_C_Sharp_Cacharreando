using Capa_Negocio;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;
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
using System.Windows.Shapes;

namespace PuntoDeVenta_Completo_Ago2023.Views
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            tbUsuario.Focus();
        }

        Error WndError;


        private void Acceder(object sender, RoutedEventArgs e)
        {
           // MainWindow main = new MainWindow();
           // main.Show();
           // this.Close();



           if ((tbUsuario.Text!="") && (tbContrasena.Text != ""))
            {
                try
                {
                    CompruebaLogin(tbUsuario.Text, tbContrasena.Text);
                }
                catch (System.Exception ex)
                {
                    WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                }
    
            }
            else
            {
                WndError = new Error();
                WndError.lblError.Text = "¡¡Debe de rellenar todos los campos!!";
                WndError.ShowDialog();
            //    MessageBox.Show("¡¡Debe de rellenar todos los campos!!");
            };
        }

        public void CompruebaLogin(string usuario, string contrasena)
        {
            try
            {
                CN_Usuarios cn = new CN_Usuarios();
                var a = cn.Login(usuario, contrasena);
                if (a.IdUsuario > 0)
                {
                    // CON ESTO ALMACENO EN UNA VARIABLE DEL SISTEMA EL ID DEL USUARIO QUE HA DE SER DEFINIDO EN LA CAPA PRESENTACION -> PROPIEDADES -> CONFIGURACION
                    Properties.Settings.Default.IdUsuario = a.IdUsuario;
                    Properties.Settings.Default.IdPrivilegio = a.IdRol;
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {
                    //MessageBox.Show("NO PUEDE TENER ACCESO");
                    WndError = new Error();
                    WndError.lblError.Text = "NO PUEDE TENER ACCESO";
                    WndError.ShowDialog();
                }

            }
            catch (System.Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString(); 
                WndError.ShowDialog();
            }



        }


        private void Cerrar(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
