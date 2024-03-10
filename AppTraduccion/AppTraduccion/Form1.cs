using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTraduccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idiomaSeleccionado = cmbLanguage.SelectedItem.ToString();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            if (idiomaSeleccionado == "Español")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
            }
            else if (idiomaSeleccionado == "English")
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }

            



            resources.ApplyResources(btnTranslate, "btnTranslate");
            resources.ApplyResources(this, "$this");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnTranslate.Text = Res.Button_Text;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        }
    }
}
