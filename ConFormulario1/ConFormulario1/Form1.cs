using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFormulario1
{
    public partial class Form1 : Form
    {

        List<string> listaNombres = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            listaNombres.Add(EdNombres.Text);
            EdNombres.Clear();
            LstNombres.DataSource = null;
            LstNombres.DataSource = listaNombres;
        }
    }
}
