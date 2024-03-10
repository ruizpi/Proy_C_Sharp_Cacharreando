using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace PuntoDeVenta_Completo_Ago2023.Recursos
{
    public class Temas
    {
        public ResourceDictionary CargarTema()
        {
            string tema = Properties.Settings.Default.Tema;
            ResourceDictionary newRes;

            if (tema == null)
            {
                tema = "Blue";
                Properties.Settings.Default.Tema = tema;
            }
            string ubicacion = "Recursos/Themes/"+tema+".xaml";

            if (File.Exists(@""+tema+".xaml"))
            {
                newRes = new ResourceDictionary
                {
                    Source = new Uri(ubicacion, UriKind.Relative),
                };
            }
            else
            {
                newRes = new ResourceDictionary
                {
                    Source = new Uri(ubicacion, UriKind.Relative),
                };

                var settings = new System.Xml.XmlWriterSettings();
                settings.Indent = true;
                var writer = System.Xml.XmlWriter.Create(@"" + tema + ".xaml", settings);
                XamlWriter.Save(newRes, writer);
            }

            return newRes;
        }
    }
}
