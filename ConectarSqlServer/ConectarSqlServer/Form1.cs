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


namespace ConectarSqlServer
{

    
    public partial class Form1 : Form
    {
      //  static string conexionString = "Server=localhost;Database=master;Trusted_Connection=True";
        static string conexionString = "Server=localhost;Database=Prueba;Trusted_Connection=True";
        SqlConnection conexion = new SqlConnection(conexionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void BOTCONECTARSE_Click(object sender, EventArgs e)
        {
          
            conexion.Open();
            MessageBox.Show("La conexion a la BBDD: " + conexion.Database + " se ha hecho con éxito");

        }

        private void BOTDESCONECTAR_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("La conexión se ha cerrado");
           
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "")
            {
                //string query = "select * from Prueba.dbo.Personas";
                string query = "select * from Personas";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data =  new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            else
            {                
                //string query = "select * from Prueba.dbo.Personas";
                string query = "select * from Personas where Pais='"+txtConsulta.Text+"'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
        }
    }
}
