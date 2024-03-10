using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ConectarPostgresql
{
    public partial class Form1 : Form
    {
        ConexionNpgSql conectandose = new ConexionNpgSql();
        string consulta = "select * from persona";

        public Form1()
        {
            InitializeComponent();
        }

        private void BOTCONECTAR_Click(object sender, EventArgs e)
        {

            conectandose.Conectar();
        }

        private void BOTDESCONECTA_Click(object sender, EventArgs e)
        {
            conectandose.Desconectar();
        }

        private void BOTCONSULTA_Click(object sender, EventArgs e)
        {
            if (EdNombre.Text == "") {
                Grid.DataSource = conectandose.DaConsulta(consulta);
            }
            else
            {
                Grid.DataSource = conectandose.DaConsulta(consulta, EdNombre.Text);
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdPersona = 0;
            IdPersona = int.Parse(EdIdPersonaIns.Text);

            conectandose.insertaDatosPersonas(IdPersona, EdNombreIns.Text, EdCedulaIns.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conectandose.BorrarDatosPersonas(int.Parse(EdIdBorrar.Text));

        }
    }
}
