using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CONECTAR2
{
    public partial class Form1 : Form
    {

        static string cadenaConexion = "Server=localhost;Database=Prueba;Trusted_Connection=True";

        SqlConnection conexion = new SqlConnection(cadenaConexion);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BOTCONSULTA_Click(object sender, EventArgs e)
        {
            string consulta = "select * from personas ";

            try
            {
                conexion.Open();
                MessageBox.Show("exito");
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter datos = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);

                GridDatos.DataSource = tabla;


                conexion.Close();









            }
            catch (Exception ex)
            {
                MessageBox.Show("No conecta");
            }

        }
    }
}
