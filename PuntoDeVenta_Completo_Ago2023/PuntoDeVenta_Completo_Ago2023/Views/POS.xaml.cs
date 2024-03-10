using Capa_Negocio;
using Microsoft.Win32;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using iTextSharp.text;
using iTextSharp.text.xml;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.tool.xml;
using Capa_Negocio;
using Capa_Entidad;

namespace PuntoDeVenta_Completo_Ago2023
{
    /// <summary>
    /// Lógica de interacción para POS.xaml
    /// </summary>
    public partial class POS : UserControl
    {
        decimal efectivo, cambio, total;


        #region INICIO

        Error WndError;
        public POS()
        {
            InitializeComponent();
            RecalculaPrecioVenta();
           
        }
        #endregion


        #region BUSCAR PRODUCTO
        private void BuscarProducto(object sender, RoutedEventArgs e)
        {
            if (tbBuscar.Text == string.Empty)
            {
               // MessageBox.Show("¡Busqueda Vacia!");
                WndError = new Error();
                WndError.lblError.Text = "¡Busqueda Vacia!";
                WndError.ShowDialog();

            }
            else
            {
                try
                {
                    CN_Carrito cc = new CN_Carrito();
                    var carrito = cc.Buscar(tbBuscar.Text);

                    if (carrito.Nombre != null)
                    {
                        tbNombre.Text = carrito.Nombre.ToString();
                        tbPrecio.Text = carrito.Precio.ToString();
                        tbCantidad.Focus();
                    }
                    else
                    {
                        WndError = new Error();
                        WndError.lblError.Text = "No se ha encontrado el producto";
                        WndError.ShowDialog();
                        tbBuscar.Text = string.Empty;
                    }

                }
                catch (Exception ex)
                {
                    WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                    tbBuscar.Text = string.Empty;
                }

            }
        }

        #endregion

        #region LIMPIAR
        void Limpiar()
        {
            tbBuscar.Text = "";
            tbNombre.Text = "";
            tbCantidad.Text = string.Empty; 
            tbPrecio.Text = string.Empty;
            RecalculaPrecioVenta();

        }
        #endregion

        #region AGREGAR PRODUCTO

        private void AgregarProducto(object sender, RoutedEventArgs e)
        {
            if ((tbNombre.Text == string.Empty || tbCantidad.Text == string.Empty))
            {
                WndError = new Error();
                WndError.lblError.Text = "No se ha seleccionado un producto";
                WndError.ShowDialog();

               // MessageBox.Show("No se ha seleccionado un producto");
            }
            else
            {
                string producto = tbNombre.Text;

                CN_Productos prod = new CN_Productos();
                DataTable dt = prod.BuscarProducto(producto);
                var codigo = dt.Rows[0][3];

                decimal cantidad = decimal.Parse(tbCantidad.Text);
                Agregar(codigo.ToString(), cantidad);
                Limpiar();
            }

        }
        #endregion

        #region FILAS, COLUMNAS Y CELDAS

        public static T GetVisualChild<T>(Visual padre) where T : Visual
        {
            T hijo = default;
            int num = VisualTreeHelper.GetChildrenCount(padre);
            for (int i = 0; i<num; i++)
            {
                Visual v = (Visual) VisualTreeHelper.GetChild(padre, i);
                hijo = v as T;
                if (hijo == null)
                {
                    hijo = GetVisualChild<T>(v);    
                }
                if (hijo != null)
                {
                    break;
                }
            }

            return hijo;
        }

        public DataGridRow GetFila (int index)
        {
            DataGridRow fila = (DataGridRow) GridProductos.ItemContainerGenerator.ContainerFromIndex(index);
            if (fila == null)
            {
                GridProductos.UpdateLayout();
                GridProductos.ScrollIntoView(GridProductos.Items[index]);
                fila = (DataGridRow)GridProductos.ItemContainerGenerator.ContainerFromIndex(index);
            }
            return fila;
        }

        public DataGridCell GetCelda(int fila, int columna)
        {
            DataGridRow filaCon = GetFila(fila);
            if (filaCon != null)
            {
                DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(filaCon);
                DataGridCell celda = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(columna);

                if (celda == null)
                {
                    GridProductos.ScrollIntoView(filaCon, GridProductos.Columns[columna]);
                    celda = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(columna);
                }
                return celda;
            }
            return null;
        }
        #endregion

        #region ANULAR ORDEN
        private void AnularOrden(object sender, RoutedEventArgs e)
        {
            efectivo = 0;
            GridProductos.Items.Clear();
            Limpiar();

        }




        #endregion

        #region RECALCULA PRECIO TOTAL

       
        void RecalculaPrecioVenta()
        {
            total = 0;
            for (int i=0; i<GridProductos.Items.Count; i++)
            {
                decimal precio;
                int j = 4;
                DataGridCell celda = GetCelda(i, j);
                TextBlock tb = celda.Content as TextBlock;
                precio = decimal.Parse(tb.Text);
                total += precio;
            }
            cambio = efectivo - total;

            lblCambio.Content = "Cambio: € " + cambio.ToString(); 
            lblEfectivo.Content = "Efectivo: € "+ cambio.ToString("###.###,00");
            lblTotal.Content = "Total: €" + total.ToString();
        }
        #endregion






        #region EXISTE


        decimal cantidad = 0;


        // AQUI HAY UNA PALABRA CLAVE QUE ES 'ref', ESTO ES PARA QUE SALGA EL VALOR POR REFERENCIA Y NO SE PIERDA EL VALOR
        public ref decimal Existe(string codigo)
        {
           
                
            for (int i = 0; i< GridProductos.Items.Count; i++)
            {
                // ESTA ES LA CELDA DONDE ESTA LA COLUMNA DEL NOMBRE DEL PRODUCTO
                int j = 1;
                DataGridCell celda = GetCelda(i,j);
                TextBlock tb = celda.Content as TextBlock;


                // AQUI ES DONDE SE ENCUENTRA LA COLUMNA DEL VALOR A CAMBIAR QUE ES CANTIDAD
                int k = 3;
                DataGridCell celda2 = GetCelda(i,k);
                TextBlock tb2 = celda2.Content as TextBlock; 
                cantidad = decimal.Parse(tb2.Text);

                //int l = 1;
                //DataGridCell celda3 = GetCelda(i, l);
                //TextBlock tb3 = celda3.Content as TextBlock;
                

                // si coincide el elemento buscado, se elimina el producto del datagrid y se retorna la cantidad que había
                if (tb.Text == codigo)
                {
                    GridProductos.Items.RemoveAt(i);
                    return ref cantidad;
                }
                else
                {
                    cantidad = 0;
                }

            }
            return ref cantidad;
            
        }
        #endregion

        #region AGREGA

        void Agregar(string producto, decimal cantidad)
        {
            CN_Carrito carrito = new CN_Carrito();
            DataTable dt;

            if (GridProductos.HasItems)
            {
                try
                {
                    cantidad += Existe(producto);
                    // LLEGADO AQUI SE METE LA CANTIDAD QUE HABIA ANTES Y LA QUE METEMOS Y SE VUELVE A AÑADIR
                    dt = carrito.Agregar(producto, cantidad);
                    GridProductos.Items.Add(dt);
                    //RecalculaPrecioVenta();

                }
                catch(Exception ex)
                {
                    WndError = new Error();
                    WndError.lblError.Text= ex.Message.ToString();
                    WndError.ShowDialog();

                }

            }
            else
            {
                dt = carrito.Agregar(producto, cantidad);
                GridProductos.Items.Add(dt);
            }
            // DEBIDO A QUE SE HAN CAMBIADO LAS CANTIDADES SE VUELVE A RECALCULAR LOS VALORES
            RecalculaPrecioVenta();
        }
        #endregion


        #region ELIMINAR PRODUCTO

        private void EliminarProducto(object sender, RoutedEventArgs e)
        {
            try
            {
                var seleccionado = GridProductos.SelectedItem;
                if (seleccionado != null)
                {
                    GridProductos.Items.Remove(seleccionado);
                    if (GridProductos.Items.Count < 1)
                    {
                        efectivo = 0;
                    }
                }
                RecalculaPrecioVenta();
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }


        }
        #endregion

        #region CAMBIAR CANTIDAD
        private void CambiarCantidad(object sender, RoutedEventArgs e)
        {
            try
            {
                var seleccionado = GridProductos.SelectedItem;
                if (seleccionado != null)
                {
                    var celda = GridProductos.SelectedCells[0];

                    var codigo = (celda.Column.GetCellContent(celda.Item) as TextBlock).Text;

                    var ingresar = new Adicionar();
                    ingresar.ShowDialog();

                    if (ingresar.Total > 0)
                    {
                        // GridProductos.Items.Remove(seleccionado);
                        GridProductos.Items.Remove(seleccionado);

                        Agregar(codigo, ingresar.Total);
                        RecalculaPrecioVenta();
                    }

                }

            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }


        }
        #endregion

        #region EFECTIVO
        private void Efectivo(object sender, RoutedEventArgs e)
        {
            try
            {
                var adicionar = new Adicionar();
                adicionar.ShowDialog();
                if (adicionar.Efectivo > 0)
                {
                    efectivo = adicionar.Efectivo;
                    RecalculaPrecioVenta();
                }
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text= ex.Message.ToString();
                WndError.ShowDialog();

            }




        }
        #endregion


        #region PAGAR E IMPRIMIR


        private void Pagar(object sender, RoutedEventArgs e)
        {
            if(GridProductos.Items.Count>=1) {
                RealizarVenta();
                efectivo = 0;
                RecalculaPrecioVenta();

            }
            else
            {
                WndError = new Error();
                WndError.lblError.Text = "¡¡¡No se ha agregado productos!!!";
                WndError.ShowDialog();
            }
        }

        CN_Carrito cN_Carrito;
        void RealizarVenta()
        {
            try
            {
                string factura = "Fº-" + DateTime.Now.ToString("yyyyMMddhhmmss") + "-" + Properties.Settings.Default.IdUsuario;
                int IdUsuario = Properties.Settings.Default.IdUsuario;
                DateTime fecha = DateTime.Now;
                cN_Carrito = new CN_Carrito();

                if (cambio >= 0)
                {
                    cN_Carrito.Venta(factura, total, fecha, IdUsuario);
                    venta_detalle(factura);
                    GridProductos.Items.Clear();
                }
                else
                {
                    WndError = new Error();
                    WndError.lblError.Text = "Ingrese un pago mayor o igual a la venta";
                    WndError.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }




        }

        void venta_detalle(string factura )
        {

            try
            {
                cN_Carrito = new CN_Carrito();
                for (int i = 0; i < GridProductos.Items.Count; i++)
                {
                    string codigo;
                    decimal totalarticulo, cantidad;

                    int j = 0;
                    DataGridCell cell = GetCelda(i, j);
                    TextBlock tb = cell.Content as TextBlock;
                    codigo = tb.Text;

                    int k = 3;
                    DataGridCell cell2 = GetCelda(i, k);
                    TextBlock tb2 = cell2.Content as TextBlock;
                    cantidad = Decimal.Parse(tb2.Text);

                    int l = 4;
                    DataGridCell cell3 = GetCelda(i, l);
                    TextBlock tb3 = cell3.Content as TextBlock;
                    totalarticulo = Decimal.Parse(tb3.Text);

                    cN_Carrito.Venta_Detalle(codigo, cantidad, factura, totalarticulo);

                }

                Imprimir(factura);
            }
            catch(Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }

        }


        // PARA PODER CREAR EL TICKET EN ESTE CASO HAY QUE IRSE AL NUGET Y INSTALAR EL PAQUETE:
        // iTextSharp
        // A PARTE EN LAS PROPIEDADES DE LA CAPA PRESENTACION, RECURSOS, Y EN LOS BOTONES BUSCO "AGREGAR NUEVO RECURSO DE TEXTO
        // CON ESTO AÑADO UN FICHERO DE TEXTO DENTRO DE RECURSOS QUE SERÁ PARA PLASMAR LOS TICKETS DE MI APLICACION
        // Y APARECERÁ EN LA CARPETA "RECURSOS" Y SERÁ DE TIPO TEXTO EL FICHERO
        // NOSOTROS LO QUE HAREMOS ES CREAR A PARTE UN FICHERO HTML QUE TENGA EL FORMATO DEL TICKET Y LO COPIAMOS TODO EL CODIGO
        // DENTRO DE ESTE FICHERO DE TEXTO Y LO RENOMBRAMOS COMO HTML
        // ABRIENDOLO CON UN NAVEGADOR VEREMOS COMO QUEDA.

        void Imprimir(string factura)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    FileName = factura + ".pdf"
                };

                string Pagina = Properties.Resources.Ticket.ToString();
                Pagina = Pagina.Replace("@Ticket", factura);
                Pagina = Pagina.Replace("@efectivo", efectivo.ToString("###.###,00"));
                Pagina = Pagina.Replace("@cambio", cambio.ToString());
                Pagina = Pagina.Replace("@Usuario", Properties.Settings.Default.IdUsuario.ToString());
                Pagina = Pagina.Replace("@Fecha", DateTime.Now.ToString("dd/MM/yyyy"));

                string filas = string.Empty;

                for (int i = 0; i < GridProductos.Items.Count; i++)
                {
                    string nombre, cantidad;
                    decimal preciounitario, totalarticulo;

                    int j = 1;
                    DataGridCell cell1 = GetCelda(i, j);
                    TextBlock tb1 = cell1.Content as TextBlock;
                    nombre = tb1.Text;

                    int k = 3;
                    DataGridCell cell2 = GetCelda(i, k);
                    TextBlock tb2 = cell2.Content as TextBlock;
                    cantidad = tb2.Text;

                    int l = 4;
                    DataGridCell cell3 = GetCelda(i, l);
                    TextBlock tb3 = cell3.Content as TextBlock;
                    totalarticulo = Decimal.Parse(tb3.Text);

                    int m = 2;
                    DataGridCell cell4 = GetCelda(i, m);
                    TextBlock tb4 = cell4.Content as TextBlock;
                    preciounitario = Decimal.Parse(tb4.Text);

                    filas += "<tr>";

                    filas += "<td align=\"center\">" + cantidad.ToString() + "</td>";
                    filas += "<td align=\"center\">" + nombre.ToString() + "</td>";
                    filas += "<td align=\"right\">" + preciounitario.ToString() + "</td>";
                    filas += "<td align=\"right\">" + totalarticulo.ToString() + "</td>";
                    filas += "</tr>";
                }
                int cant = GridProductos.Items.Count;
                Pagina = Pagina.Replace("@cant_articulos", cant.ToString());
                Pagina = Pagina.Replace("@Grid", filas);
                Pagina = Pagina.Replace("@TOTAL", total.ToString());


                // ESTO NO FUNCIONA EN WPF
                // DialogResult dr = saveFile.ShowDialog();
                // HAY QUE HACER ESTO OTRO:
                // Nullable<bool> result = dlg.ShowDialog();
                Nullable<bool> resultado = saveFile.ShowDialog();

                if (resultado == true)
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        int artfilas = GridProductos.Items.Count;

                        iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(298, 420 + (artfilas * 12));
                        Document pdfDoc = new Document(pageSize, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        using (StringReader sr = new StringReader(Pagina))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        pdfDoc.Close();
                        stream.Close();
                    }
                    WndError = new Error();
                    WndError.Msg.Content = "INFORMACION";
                    WndError.lblError.Text = "Venta realizada con éxito";
                    WndError.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }

        }

        #endregion
    }
}
