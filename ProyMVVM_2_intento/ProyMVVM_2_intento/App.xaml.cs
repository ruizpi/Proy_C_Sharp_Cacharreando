using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ProyMVVM_2_intento
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            // Esto es para hacer una instancia de la ventana y mostrarla
            MainWindow = new MainWindow();
            MainWindow.Show();
            // esto es para indicarle que base que en realidad es la clase Application gestione OnStartUp pasandole el mismo argumento
            base.OnStartup(e);  
        }
    }
}
