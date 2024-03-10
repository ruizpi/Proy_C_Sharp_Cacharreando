using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTraduccion3
{
    public partial class FormAltas : Form
    {
        public FormAltas()
        {
            InitializeComponent();
        }

        private void FormAltas_Load(object sender, EventArgs e)
        {
            Traduccion.Traductor.tradFormulario(this, Form1.idioma);
        }
    }
}
