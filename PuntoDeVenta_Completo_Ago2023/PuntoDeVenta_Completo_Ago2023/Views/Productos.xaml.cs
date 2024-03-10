using Capa_Negocio;
using PuntoDeVenta_Completo_Ago2023.Views;
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
using Capa_Negocio;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;

namespace PuntoDeVenta_Completo_Ago2023
{
    /// <summary>
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : UserControl
    {

        readonly CN_Productos obj_CN_Productos = new CN_Productos();
        Error WndError;


        #region COMIENZO
        public Productos()
        {
            InitializeComponent();
            GridDatos.ItemsSource = obj_CN_Productos.BuscarProducto("").DefaultView;
            
        }
        #endregion

        #region CRUD PRODUCTOS

        #region AGREGAR PRODUCTO
        private void AgregarProducto(object sender, RoutedEventArgs e)
        {
            try
            {
                CRUDProductos ventanaProductos = new CRUDProductos();
                FrameProductos.Content = ventanaProductos;
                Contenido.Visibility = Visibility.Hidden;
                ventanaProductos.BtnCrearProducto.Visibility = Visibility.Visible;
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }


        }
        #endregion

        #region Buscar
        public void Buscar(string busqueda)
        {
            try
            {
                GridDatos.ItemsSource = obj_CN_Productos.BuscarProducto(busqueda).DefaultView;
            }
            catch (Exception ex) {
                WndError = new Error();
                WndError.lblError.Text = ex.Message;
                WndError.ShowDialog();
            }
           
        }



        #endregion




        #region BUSCANDO PRODUCTO
        private void Buscando(object sender, TextChangedEventArgs e)
        {
            Buscar(tbBuscar.Text);
        }

        #endregion

        #region ELIMINAR PRODUCTO
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdProducto = (int)((Button)sender).CommandParameter;
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.IdProducto = IdProducto;
                ventana.Consultar();
                ventana.TITULO.Text = "Eliminar Producto";
                ventana.tbNombre.IsEnabled = false;
                ventana.tbCodigo.IsEnabled = false;
                ventana.tbCantidad.IsEnabled = false;
                ventana.tbActivo.IsEnabled = false;
                ventana.tbPrecio.IsEnabled = false;
                ventana.cbGrupo.IsEnabled = false;
                ventana.tbUnidadMedida.IsEnabled = false;
                ventana.tbDescripcion.IsEnabled = false;
                ventana.BtnSubirImagen.IsEnabled = false;
                ventana.BtnEliminar.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }





        }
        #endregion

        #region MODIFICAR PRODUCTO
        private void Modificar(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdProducto = (int)((Button)sender).CommandParameter;
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.IdProducto = IdProducto;
                ventana.Consultar();
                ventana.TITULO.Text = "Actualización de Producto";
                ventana.tbNombre.IsEnabled = true;
                ventana.tbCodigo.IsEnabled = true;
                ventana.tbCantidad.IsEnabled = true;
                ventana.tbActivo.IsEnabled = true;
                ventana.tbPrecio.IsEnabled = true;
                ventana.cbGrupo.IsEnabled = true;
                ventana.tbUnidadMedida.IsEnabled = true;
                ventana.tbDescripcion.IsEnabled = true;
                ventana.BtnSubirImagen.IsEnabled = true;
                ventana.BtnCrearProducto.Visibility = Visibility.Hidden;
                ventana.BtnEliminar.Visibility = Visibility.Hidden;
                ventana.BtnEditar.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }





        }
        #endregion

        #region READ
        private void ClickConsultar(object sender, RoutedEventArgs e)
        {
            try
            {
                int IdProducto = (int)((Button)sender).CommandParameter;
                CRUDProductos ventana = new CRUDProductos();
                FrameProductos.Content = ventana;
                Contenido.Visibility = Visibility.Hidden;
                ventana.IdProducto = IdProducto;
                ventana.Consultar();
                ventana.TITULO.Text = "Consulta de Producto";
                ventana.tbNombre.IsEnabled = false;
                ventana.tbCodigo.IsEnabled = false;
                ventana.tbCantidad.IsEnabled = false;
                ventana.tbActivo.IsEnabled = false;
                ventana.tbPrecio.IsEnabled = false;
                ventana.cbGrupo.IsEnabled = false;
                ventana.tbUnidadMedida.IsEnabled = false;
                ventana.tbDescripcion.IsEnabled = false;
                ventana.BtnSubirImagen.IsEnabled = false;
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }

        }
        #endregion


        #endregion


    }
}
