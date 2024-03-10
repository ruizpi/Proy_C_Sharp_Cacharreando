using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using static Microsoft.TeamFoundation.Client.CommandLine.Options;
using Capa_Negocio;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;
using System;

namespace PuntoDeVenta_Completo_Ago2023.Views
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : UserControl
    {

        readonly CN_Usuarios objeto_CN_Usuarios = new CN_Usuarios();
        Error WndError;


//        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString);

        #region COMIENZO
        public Usuarios()
        {
            InitializeComponent();
            GridDatos.ItemsSource = objeto_CN_Usuarios.BuscarUsuario("").DefaultView;

            // SUSTITUIMOS EL CARGAR DATOS POR BUSCAR USANDO UNA CADENA VACÍA
            // CargarDatos();
        }
        #endregion
        
        #region CargarUsuarios
        void CargarDatos()
        {

            GridDatos.ItemsSource = objeto_CN_Usuarios.BuscarUsuario("").DefaultView;


            //con.Open();
            //string consulta = "select IdUsuario, Nombre, Apellidos, Tlf, Email, NombreRol from Usuarios inner join Roles on Usuarios.idRol=Roles.IdRol order by IdUsuario ASC";
            //SqlCommand cmd = new SqlCommand(consulta,con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt =  new DataTable();
            //da.Fill(dt);
            //GridDatos.ItemsSource = dt.DefaultView;
            //con.Close();

        }
        #endregion
        
        #region Agregar

        private void Agregar(object sender, RoutedEventArgs e)
        {
     


            try
            {
                CRUDUsuarios ventana = new CRUDUsuarios();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.BtnCrear.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }



        }
        #endregion



      


        #region Buscando

        public void Buscar(string busqueda)
        {
            try
            {
                GridDatos.ItemsSource = objeto_CN_Usuarios.BuscarUsuario(busqueda).DefaultView;
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }
            
        }
        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }
        #endregion


        #region Consultar
        private void ClickConsultar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDUsuarios ventana = new CRUDUsuarios();
                ventana.IdUsuario = id;
                ventana.Consultar();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.TITULO.Text = "CONSULTA DE USUARIO";

                ventana.tbNombres.IsEnabled = false;
                ventana.tbApellidos.IsEnabled = false;
                ventana.tbDNI.IsEnabled = false;
                ventana.tbEMAIL.IsEnabled = false;
                ventana.tbFECHNAC.IsEnabled = false;
                ventana.tbTLF.IsEnabled = false;
                ventana.tbUsuario.IsEnabled = false;
                ventana.tbPassword.IsEnabled = false;
                ventana.tbUsuario.IsEnabled = false;
                ventana.cbRoles.IsEnabled = false;
                ventana.SubirImagen.IsEnabled = false;
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message;
                WndError.ShowDialog();
            }



        }

        #endregion

        private void ClickEliminar(object sender, RoutedEventArgs e)
        {

            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDUsuarios ventana = new CRUDUsuarios();
                ventana.IdUsuario = id;
                ventana.Consultar();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.TITULO.Text = "ELIMINAR USUARIO";

                ventana.tbNombres.IsEnabled = false;
                ventana.tbApellidos.IsEnabled = false;
                ventana.tbDNI.IsEnabled = false;
                ventana.tbEMAIL.IsEnabled = false;
                ventana.tbFECHNAC.IsEnabled = false;
                ventana.tbTLF.IsEnabled = false;
                ventana.tbUsuario.IsEnabled = false;
                ventana.tbPassword.IsEnabled = false;
                ventana.tbUsuario.IsEnabled = false;
                ventana.cbRoles.IsEnabled = false;
                ventana.SubirImagen.IsEnabled = false;
                ventana.BtnEliminar.Visibility = Visibility.Visible;
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message;
                WndError.ShowDialog();
            }


        }

        private void ClickEditar(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = (int)((Button)sender).CommandParameter;
                CRUDUsuarios ventana = new CRUDUsuarios();
                ventana.IdUsuario = id;
                ventana.Consultar();
                FrameUsuarios.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.TITULO.Text = "ACTUALIZAR USUARIO";

                ventana.tbNombres.IsEnabled = true;
                ventana.tbApellidos.IsEnabled = true;
                ventana.tbDNI.IsEnabled = true;
                ventana.tbEMAIL.IsEnabled = true;
                ventana.tbFECHNAC.IsEnabled = true;
                ventana.tbTLF.IsEnabled = true;
                ventana.tbUsuario.IsEnabled = true;
                ventana.tbPassword.IsEnabled = true;
                ventana.tbUsuario.IsEnabled = true;
                ventana.cbRoles.IsEnabled = true;
                ventana.SubirImagen.IsEnabled = true;
                ventana.BtnEditar.Visibility = Visibility.Visible;
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message;
                WndError.ShowDialog();
            }




        }
    }
}
