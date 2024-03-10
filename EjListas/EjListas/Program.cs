using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace EjListas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ArrayList Lista1 = new ArrayList();

            Lista1.Add("pollo");
            Lista1.Add(345);
            Lista1.Add("cenutrio");


            //foreach (var dato in Lista1) {

            //    if (Regex.IsMatch(dato, @"^\d+$")){
            //        MessageBox.Show(dato.ToString());
            //    }
            //    else
            //    {
            //        MessageBox.Show(dato);
            //    }
                
            ////}


            List<int> Lista = new List<int>();

            Lista.Add(234);
            Lista.Add(456);

            foreach (var dato in Lista1) { 
                MessageBox.Show(dato.ToString());

            }
            




            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
