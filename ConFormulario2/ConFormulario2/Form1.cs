using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFormulario2
{
    public partial class Form1 : Form
    {

        List<string> ListaNombres = new List<string>(); 


        public Form1()
        {
            InitializeComponent();
        }

        private void BotOk_Click(object sender, EventArgs e)
        {
            ListaNombres.Add(EdNombre.Text);

            LstBox.DataSource = null;
            LstBox.DataSource = ListaNombres;
        }

        private void BOTELIMINAR_Click(object sender, EventArgs e)
        {
            ListaNombres.Remove(EdNombre.Text);
            LstBox.DataSource = null;
            LstBox.DataSource= ListaNombres;

        }

        private void BOTMODIFICAR_Click(object sender, EventArgs e)
        {
            int indice = ListaNombres.IndexOf(EdNombre.Text);
            ListaNombres.RemoveAt(indice-1);
            ListaNombres.Insert(indice, EdNuevoNombre.Text);
            LstBox.DataSource = null;
            LstBox.DataSource =ListaNombres;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
