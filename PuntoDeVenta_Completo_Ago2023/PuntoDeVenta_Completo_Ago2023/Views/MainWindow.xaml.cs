
using PuntoDeVenta_Completo_Ago2023.Recursos;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;
using PuntoDeVenta_Completo_Ago2023.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PuntoDeVenta_Completo_Ago2023
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Error WndError;
        public MainWindow()
        {
            InitializeComponent();

            // CON ESTO LO QUE HACEMOS ES LLAMAR AL DASHBOARD PRIMERO PARA VER COMO VAN LAS VENTAS
            DataContext = new DashBoard();

            string tema = Properties.Settings.Default.Tema;

            // Con esto lo que hacemos es que si el usuario no es un Administrador
            // no puede tener acceso a meter ni productos ni dar de alta a usuarios
            if (Properties.Settings.Default.IdPrivilegio != 1)
            {
                lvProductos.Visibility = Visibility.Hidden;
                lvUsuarios.Visibility = Visibility.Hidden;
            }


            this.Temas.Items.Add("Blue");
            this.Temas.Items.Add("Dark");
            this.Temas.Items.Add("Purple");

            if (tema != null)
            {
                if (tema == "Blue")
                    Temas.SelectedIndex = 0;

                if (tema == "Dark")
                    Temas.SelectedIndex = 1;

                if (tema == "Purple")    
                    Temas.SelectedIndex = 2;
              
            }
            CargarTema();


        }

        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.8;
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PreviewMouseLeftDown(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void UsuariosClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }


        private void Productos_click(object sender, RoutedEventArgs e)
        {
            DataContext = new Productos();
        }

        private void DashBoard(object sender, RoutedEventArgs e)
        {
            DataContext = new DashBoard();
        }

        private void Ventas(object sender, RoutedEventArgs e)
        {
            DataContext = new POS();
        }



        private void AcercaDe(object sender, RoutedEventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void ClickMiCuenta(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnCuenta_Click(object sender, RoutedEventArgs e)
        {
            MiCuenta miCuenta = new MiCuenta();
            miCuenta.ShowDialog();
        }


        // ESTO ES PARA HACER QUE LA VENTANA DE LA APLICACION SEA VISIBLE, MOVIBLE, SE REDIMENSIONE ETC

        #region MOVER VENTANA


        // SE VALIDARÁ QUE AL DARLE DOBLE CLICK A LA BARRA DE TITULO LA APLICACION CAMBIARÁ DE TAMAÑO
        // TAMBIEN SI ARRASTRO AL BORDE SUPERIOR DEL ESCRITORIO SE MAXIMIZARÁ
        private void Mover(Border header)
        {
            var restaurar = false;
            header.MouseLeftButtonDown += (s, e)=>
            {
                if (e.ClickCount == 2)
                {
                    if ((ResizeMode == ResizeMode.CanResize) || (ResizeMode == ResizeMode.CanResizeWithGrip)){
                        CambiarEstado();
                    }
                }
                else    {
                    if (WindowState == WindowState.Maximized)
                    {
                        restaurar = true;
                    }
                    DragMove();

                }
            };

            header.MouseLeftButtonUp += (s, e) =>
            {
                restaurar = false;
            };

            header.MouseMove += (s, e) =>
            {
                if (restaurar)
                {
                    try
                    {
                        restaurar = false;
                        var mouseX = e.GetPosition(this).X;
                        var width = RestoreBounds.Width;
                        var x = mouseX - width / 2;

                        if (x < 0)
                        {
                            x = 0;
                        }
                        else if (x + width > SystemParameters.PrimaryScreenWidth)
                        {
                            x = SystemParameters.PrimaryScreenWidth - width;
                        }

                        WindowState = WindowState.Normal;
                        Left = x;
                        Top = 0;
                        DragMove();

                    }
                    catch (System.Exception ex)
                    {
                        WndError = new Error();
                        WndError.lblError.Text = ex.Message.ToString();
                        WndError.ShowDialog();

                    }
                }
            };
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void CambiarEstado()
        {
            switch (WindowState)
            {
                case WindowState.Normal:
                    {
                        WindowState = WindowState.Normal;
                        break;
                    }
                case WindowState.Maximized:
                    {
                        WindowState = WindowState.Maximized;   
                        break;
                    }
                    
                case WindowState.Minimized:
                    {
                        WindowState = WindowState.Minimized;
                        break;
                    }
            }
        }

        private void RestaurarVentana(object sender, RoutedEventArgs e)
        {
            Mover(sender as Border);
        }
        #endregion


        // CON ESTO LO QUE VAMOS A PODER HACER ES CAMBIAR EL TEMA DE LA APLICACION
        // ANTES DE HACER ESTO HAY QUE DARLE A LA CAPA PRESENTACION -> PROPIEDADES -> Y EN CONFIGURACION DEFINIR LA VARIABLE TEMA
        // QUE ES LA MISMA QUE APARECE EN ESTA SENTENCIA:
        // Properties.Settings.Default.Tema = "Blue";

        private void CambiarTema(object sender, SelectionChangedEventArgs e)
        {
            if (Temas.SelectedIndex==0)
            {
                Properties.Settings.Default.Tema = "Blue";
            }else if (Temas.SelectedIndex==1)
            {
                Properties.Settings.Default.Tema = "Dark";  
            }else if (Temas.SelectedIndex == 2)
            {
                Properties.Settings.Default.Tema = "Purple";
            }
            Properties.Settings.Default.Save();
            CargarTema();
        }
        public void CargarTema()
        {
            Temas temas = new Temas();
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(temas.CargarTema());

        }
    }
}
