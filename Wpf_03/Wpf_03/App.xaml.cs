using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_03
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, EventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Title = "Mi ventana";
            wnd.Show();

        }
       
    }
}
