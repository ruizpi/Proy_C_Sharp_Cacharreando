using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ConectarPostgresql
{
    internal class ConexionNpgSql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;User Id=postgres; Password=44038930; Database = postgres");


        public void Conectar()
        {
            conn.Open();
            MessageBox.Show("Conectado");
        }

        public void Desconectar()
        {
            conn.Close();
            MessageBox.Show("Desconectado");
        }

        public DataTable DaConsulta(string consulta, string filtroNombre = null)
        {
            string miConsulta = "";

            if (filtroNombre != "" && filtroNombre != null)
            {
                miConsulta = consulta + " where 1 = 1 and Nombre='" + filtroNombre + "'";
            }
            else
            {
                miConsulta = consulta;
            }

            NpgsqlCommand comando = new NpgsqlCommand(miConsulta, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            da.Fill(tabla);

            return tabla;
            
        }

        public void insertaDatosPersonas(int idpersona, string nombre, string cedula)
        {
            int valor = 0;
            string sqlInser1 = "insert into persona (idpersona, nombre, cedula) values (";
            string sqlInsertFin = ")";

            string consultaInsercion = sqlInser1 + idpersona.ToString()+",'"+nombre+"',"+
                "'"+cedula+"'"+sqlInsertFin;


            if (conn == null || conn.State is ConnectionState.Closed)
            {
                conn.Open();
            }


            NpgsqlCommand comando = new NpgsqlCommand(consultaInsercion, conn);
            valor = comando.ExecuteNonQuery();
            if (valor == 0) {
                MessageBox.Show("No se ha realizado la operacion");
            }
            else
            {
                MessageBox.Show("Se ha realizado la conexión perfectamente");
            }

        }

        public void BorrarDatosPersonas (int idpersona)
        {
            int valor = 0;

            string sqlBorrar = "Delete from persona where idPersona=" + idpersona;

            

            if (conn==null || conn.State is ConnectionState.Closed)
            {
                conn.Open();
            }
            

            NpgsqlCommand comando = new NpgsqlCommand (sqlBorrar, conn);
            valor = comando.ExecuteNonQuery();

            if (valor == 0) {
                MessageBox.Show("No se pudo realizar la operación");
            }
            else
            {
                MessageBox.Show("Eliminado el registro con id " + idpersona.ToString());
            }
                



        }
    }
}
