using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTraduccion3
{

    

    public partial class Form1 : Form
    {

        public static string idioma = "en";
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // this.Controls.Clear();
            Traduccion.Traductor.tradFormulario(this, idioma);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormAltas formAlta = new FormAltas();
            formAlta.ShowDialog();
            formAlta.Dispose();

            //Traduccion.Traductor.tradFormulario(this, "en");
        }
    }
}
