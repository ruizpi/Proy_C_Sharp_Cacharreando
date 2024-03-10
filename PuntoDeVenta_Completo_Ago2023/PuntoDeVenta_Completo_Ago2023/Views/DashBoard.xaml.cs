using Capa_de_datos;
using LiveCharts;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace PuntoDeVenta_Completo_Ago2023.Views
{
    /// <summary>
    /// Lógica de interacción para DashBoard.xaml
    /// </summary>
    public partial class DashBoard : UserControl
    {
        
            
            
        // ESTA VARIABLE NOS VA A PERMITIR CARGAR LOS DATOS DE LA GRAFICA
        public ChartValues<decimal> Values { get; set; }
        Error WndError;

        public DashBoard()
        {
            InitializeComponent();

            try
            {
                CD_Dashboard dash = new CD_Dashboard();
                lbltotales.Content = dash.CantidadVentas().ToString();
                lblartdisponibles.Content = dash.Articulos().ToString();

                Values = new ChartValues<decimal>();

                foreach (DataRow row in dash.Grafico().Rows)
                {
                    decimal i = decimal.Parse(row["Cantidad_Total"].ToString());
                    Values.Add(i);
                }
                DataContext = this;

            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }

            
        }
    }
}
