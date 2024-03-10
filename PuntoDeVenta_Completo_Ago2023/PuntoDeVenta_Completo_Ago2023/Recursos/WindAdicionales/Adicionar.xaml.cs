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

namespace PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales
{
    /// <summary>
    /// Lógica de interacción para Adicionar.xaml
    /// </summary>
    public partial class Adicionar : Window
    {

        public Decimal Total { get; set; }
        public Decimal Efectivo { get; set; }

        Error WndError;


        public Adicionar()
        {
            InitializeComponent();
            tbCantidad.Focus();
        }

        #region ACEPTAR CANTIDAD
        private void AceptarCantidad(object sender, RoutedEventArgs e)
        {
            try
            {

                bool esNumerico = decimal.TryParse(tbCantidad.Text, out _);

                if (esNumerico)
                {
                    Total = decimal.Parse(tbCantidad.Text);
                    Efectivo = decimal.Parse(tbCantidad.Text);
                    this.Close();
                }
                else
                {
                    this.Close();
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

        #region CANCELAR CANTIDAD
        private void CancelarCantidad(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        #endregion
    }
}
