using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
using Capa_Entidad;
using Capa_Negocio;
using Microsoft.Win32;
using Capa_Criptografica;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;

namespace PuntoDeVenta_Completo_Ago2023.Views
{
    /// <summary>
    /// Lógica de interacción para CRUDProductos.xaml
    /// </summary>
    public partial class CRUDProductos : Page
    {
        CN_Grupos objeto_CN_Grupos = new CN_Grupos();
        CN_Productos objeto_CN_Productos = new CN_Productos();
        CE_Productos objeto_CE_Productos = new CE_Productos();
        Error error;


        string patron = Seguridad.Patron;
        public int IdProducto;

        #region INICIAL
        public CRUDProductos()
        {
            InitializeComponent();
            // aqui cargamos el combobox con los grupos
            CargarGrupos();
        }
        #endregion

        #region VOLVER
        private void VolverMain(object sender, RoutedEventArgs e)
        {
            Content = new Productos();
        }

        #endregion

        #region READ
        public void Consultar()
        {
            try
            {
                var a = objeto_CN_Productos.Consulta(IdProducto);

                tbNombre.Text = a.Nombre.ToString();
                tbCodigo.Text = a.Codigo.ToString();
                tbPrecio.Text = a.Precio.ToString();
                tbActivo.IsChecked = a.Activo;
                tbCantidad.Text = a.Cantidad.ToString();
                tbUnidadMedida.Text = a.UnidadMedida.ToString();
                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.Source = (ImageSource)imgs.ConvertFrom(a.Img);
                tbDescripcion.Text = a.Descripcion.ToString();


                cbGrupo.SelectedValue = a.IdGrupo;
                CE_Grupos ce = objeto_CN_Grupos.Nombre(a.IdGrupo);
                cbGrupo.Text = ce.NomGrupo.ToString();
            }
            catch (Exception ex)
            {
                Error WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }


        }


        #endregion

        #region LLENAR GRUPOS

        void CargarGrupos()
        {
            try
            {
                List<string> grupos = objeto_CN_Grupos.ListarGrupos();
                for (int i = 0; i < grupos.Count; i++)
                {
                    cbGrupo.Items.Add(grupos[i]);
                }
            }
            catch(Exception ex)
            {
                Error WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }




        }

        #endregion

        #region VALIDAR CAMPOS

        public bool CamposLlenos()
        {
            if (tbNombre.Text == "" || tbCodigo.Text=="" || cbGrupo.Text=="" || tbPrecio.Text=="" || tbCantidad.Text=="" || tbUnidadMedida.Text=="" || tbDescripcion.Text == "")
            {
                return false;
            }else
            {
                return true;
            }
        }

        #endregion

        #region CRUD

        #region CREA PRODUCTO
        private void CrearProducto(object sender, RoutedEventArgs e)
        {
            if (CamposLlenos() == true)
            {
                try
                {
                    int idGrupo = objeto_CN_Grupos.IdGrupo(cbGrupo.Text);
                    objeto_CE_Productos.Nombre = tbNombre.Text;
                    objeto_CE_Productos.Codigo = tbCodigo.Text;
                    objeto_CE_Productos.Precio = Decimal.Parse(tbPrecio.Text);
                    objeto_CE_Productos.Cantidad = Decimal.Parse(tbCantidad.Text);
                    objeto_CE_Productos.Activo = (bool)tbActivo.IsChecked;
                    objeto_CE_Productos.UnidadMedida = tbUnidadMedida.Text;
                    objeto_CE_Productos.Img = data;
                    objeto_CE_Productos.Descripcion = tbDescripcion.Text;
                    objeto_CE_Productos.IdGrupo = idGrupo;

                    objeto_CN_Productos.Insertar(objeto_CE_Productos);

                    Content = new Productos();

                }
                catch(Exception ex)
                {
                    Error WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                }


            }
            else
            {
                Error WndError = new Error();
                WndError.lblError.Text = "Los campos no se pueden quedar vacios!";
                WndError.ShowDialog();
            }

        }
        #endregion

        #region ELIMINAR PRODUCTO
        private void EliminarProducto(object sender, RoutedEventArgs e)
        {
            try
            {
                objeto_CE_Productos.IdArticulos = IdProducto;
                objeto_CN_Productos.Eliminar(objeto_CE_Productos);
                Content = new Productos();
            }
            catch (Exception ex)
            {

                Error WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();

            }

        }
        #endregion

  

        #region EDITAR PRODUCTO
        private void EditarProducto(object sender, RoutedEventArgs e)
        {
            if (CamposLlenos() == true)
            {
                try
                {
                    int IdGrupo = objeto_CN_Grupos.IdGrupo(cbGrupo.Text);
                    objeto_CE_Productos.IdArticulos = IdProducto;
                    objeto_CE_Productos.Nombre = tbNombre.Text;
                    objeto_CE_Productos.Codigo = tbCodigo.Text;
                    objeto_CE_Productos.Precio = Decimal.Parse(tbPrecio.Text);
                    objeto_CE_Productos.Cantidad = Decimal.Parse(tbCantidad.Text);
                    objeto_CE_Productos.Activo = (bool)tbActivo.IsChecked;
                    objeto_CE_Productos.UnidadMedida = tbUnidadMedida.Text;
                    objeto_CE_Productos.IdGrupo = IdGrupo;

                    objeto_CE_Productos.Descripcion = tbDescripcion.Text;

                    objeto_CN_Productos.CD_Actualizar(objeto_CE_Productos);

                    Content = new Productos();

                }
                catch (Exception ex)
                {
                    Error WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                }
                


            }
            else
            {
                Error WndError = new Error();
                WndError.lblError.Text = "Los campos no pueden estar vacíos";
                WndError.ShowDialog();
            }

            if (imagensubida == true)
            {
                try
                {
                    objeto_CE_Productos.IdArticulos = IdProducto;
                    objeto_CE_Productos.Img = data;

                    objeto_CN_Productos.CN_ActualizarIMG(objeto_CE_Productos);
                    Content = new Productos();

                }
                catch(Exception ex)
                {
                    Error WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                }



            }


        }
        #endregion

        #region SUBIR IMAGEN

            byte[] data;
            private bool imagensubida = false;

            private void SubirImagen(object sender, RoutedEventArgs e)
            {
                try
                {
                    OpenFileDialog odf = new OpenFileDialog();
                    if (odf.ShowDialog() == true)
                    {
                        FileStream fs = new FileStream(odf.FileName, FileMode.Open, FileAccess.Read);
                        data = new byte[fs.Length];
                        fs.Read(data, 0, Convert.ToInt32(data.Length));
                        fs.Close();
                        ImageSourceConverter imgs = new ImageSourceConverter();
                        imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(odf.FileName.ToString()));
                    }
                    imagensubida = true;

                }
                catch(Exception ex) 
                {
                    Error WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                }
                
            }

        #endregion


        #endregion
    }
}
