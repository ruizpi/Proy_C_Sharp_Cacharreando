using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConInforme
{
    public partial class FormInforme : Form
    {
        public FormInforme()
        {
            InitializeComponent();
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntodeVentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            //  this.clientesTableAdapter.Fill(this.puntodeVentaDataSet.Clientes);

            this.clientesBindingSource.DataSource = Negocios.NegClientes.getClientes();

            this.RptViewer.RefreshReport();
            //
        }

        private void RptViewer_Load(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.DataSource = Negocios.NegClientes.getClientes(EdNombre.Text, EdApellidos.Text, EdTelefono.Text);

            this.RptViewer.RefreshReport();

        }

    }
}
