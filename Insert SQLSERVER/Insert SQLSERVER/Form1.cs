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
using System.Data.Common;


namespace Insert_SQLSERVER
{
    public partial class Form1 : Form
    {

        static string cadenaConexion = "Server=localhost;Database=Prueba;Trusted_Connection=True";
        SqlConnection conexion = new SqlConnection(cadenaConexion);
        String SqlConsulta = "Select * from Personas where 1 = 1 ";



        public Form1()
        {
            InitializeComponent();
        }

        private void BOTCONECTA_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Exito en la conexión");
            }catch (Exception)
            {
                MessageBox.Show("Problemas de conexión");
            }
            
        }

        private void BOTDESCONECTA_Click(object sender, EventArgs e)
        {

            if (conexion != null && conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
                MessageBox.Show("Conexión cerrada");
            }
                

        }

        private void BOTCONSULTA_Click(object sender, EventArgs e)
        {
            if (EdPaisFiltro.Text=="") {

                SqlCommand comando = new SqlCommand(SqlConsulta, conexion);
                SqlDataAdapter datos = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                DataGrid.DataSource = tabla;
                
            }
            else
            {
                string filtroSql = " and Pais='" + EdPaisFiltro.Text + "'";
                //SqlConsulta = SqlConsulta + filtroSql;
                SqlCommand comando = new SqlCommand(SqlConsulta + filtroSql, conexion);
                SqlDataAdapter datos = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                DataGrid.DataSource = tabla;
            }
        }


        private void BOTAGREGAR_Click(object sender, EventArgs e)
        {
            // insert into Personas ([nombre], [apellidos], [dni], [pais] values ('','','','');
            string cadena = "insert into Personas ([Nombre], [Apellidos], [DNI], [Pais]) " +
                            " values ('" + EdNombre.Text + "','" + EdApellidos.Text + "','" + EdDNI.Text + "','" + EdPais.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("La persona " + EdNombre.Text + " con apellidos " + EdApellidos.Text + " se ha agregado");

            EdNombre.Text = "";
            EdApellidos.Text = "";
            EdPais.Text = "";
            EdDNI.Text = "";

        }

        private void BOTELIMINAR_Click(object sender, EventArgs e)
        {
                int flag = 0;
                string eliminaSql = "Delete from Personas ";
                string filtro1 = " Nombre='"+EdNombre.Text;
                string filtro2 = " and Apellidos='"+EdApellidos.Text;

                string sqlBorra = eliminaSql + " where " + filtro1 + "' " + filtro2 + "'";


                SqlCommand borra = new SqlCommand(sqlBorra, conexion);
                flag = borra.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show("Se borró correctamente");
                }
                else
                {
                    MessageBox.Show("No se realizó la operación");
                }

        }

        private void BOTACTUALIZAR_Click(object sender, EventArgs e)
        {


            int id = 0;
            int flag = 0;

            id = int.Parse(EdID.Text);



            string cadena = "update Personas set Nombre = '" + EdNombre.Text + "' where id=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Actualizado con éxito");
                DataGrid.Refresh();
            }
            else
            {
                MessageBox.Show("ocurrió algún problema y no actualizó");
            }
        }
    }
}
