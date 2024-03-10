using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using MSForms;
using System.Media;
using System.Text.RegularExpressions;

namespace Traduccion
{
    

    public class Traductor
    {
        
        public static void tradFormulario (Form formulario, string lang)
        {
           
          
            string valor = "";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
        //    ResourceManager rmo = new ResourceManager("Traduccion.Res", Assembly.GetExecutingAssembly());
            var resourceManager = new ResourceManager(typeof(Traduccion.resource));

            valor = resourceManager.GetString("LabNombre",new CultureInfo(lang));

            Console.WriteLine("de LabNombre es " + valor);

            foreach (System.Windows.Forms.Control control in formulario.Controls)
            {

                valor = resourceManager.GetString(control.Name, new CultureInfo(lang));
                
                control.Text = valor;

                Console.WriteLine("Traduccion de " + control.Name + " es " + valor);

            }

        

        }
    }
}
