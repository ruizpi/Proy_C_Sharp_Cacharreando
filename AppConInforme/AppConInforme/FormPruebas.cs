using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppConInforme
{
    public partial class FormPruebas : Form
    {
        public FormPruebas()
        {
            InitializeComponent();
        }

        private void FormPruebas_Load(object sender, EventArgs e)
        {
            CmbClientes.DataSource = Negocios.NegClientes.getClientes("", "", "");
            CmbClientes.ValueMember = "ID";
            CmbClientes.DisplayMember = "FullName";
       
            CmbClientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbClientes.AutoCompleteSource = AutoCompleteSource.ListItems;



            GridPruebas.DataSource = Negocios.NegClientes.getDatosFacturacion("", "", "");
        }

        private void BtnFiltraDatos_Click(object sender, EventArgs e)
        {
            // Application.DoEvents()   -> como el Application.processmessages
        }
    }
}
