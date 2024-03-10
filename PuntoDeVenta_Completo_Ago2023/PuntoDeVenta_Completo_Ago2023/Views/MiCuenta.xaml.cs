using Capa_Entidad;
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
    /// Lógica de interacción para MiCuenta.xaml
    /// </summary>
    public partial class MiCuenta : Window
    {
        public MiCuenta()
        {
            InitializeComponent();
            CargarDatos();
        }

        Error WndError;
        public void CargarDatos()
        {
            CN_Usuarios cn = new CN_Usuarios();
            CN_Privilegios priv = new CN_Privilegios();

            var a = cn.Cargar(Properties.Settings.Default.IdUsuario);

            try
            {
                lblnombre.Text = lblnombre.Text + " " + a.Nombre;
                lblapellidos.Text = lblapellidos.Text + " " + a.Apellidos;
                lblcorreo.Text = lblcorreo.Text + " " + a.Email;

                lblrol.Text = lblrol.Text + " " + priv.GetNombreRol(a.IdRol);

                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.Source = (ImageSource)imgs.ConvertFrom(a.Img);

            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());

                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();

            }

            //  lblrol.Text = lblrol.Text + " " + a.Rol

        }


        private void CierraMiCuenta(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }
    }
}
