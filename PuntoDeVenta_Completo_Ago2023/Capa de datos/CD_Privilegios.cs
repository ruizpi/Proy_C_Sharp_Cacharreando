using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_datos;
using Capa_Entidad;
using System.Data;
using System.ComponentModel;

namespace Capa_de_datos
{
    public class CD_Privilegios
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Privilegios ce = new CE_Privilegios();

        #region IdRol
        public int IdRol(string NombreRol)
        {
            SqlCommand llamaProcAlmacenado = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_P_IdRol",
                CommandType =  CommandType.StoredProcedure
            };

            llamaProcAlmacenado.Parameters.AddWithValue("@NombreRol", NombreRol);
            object valor = llamaProcAlmacenado.ExecuteScalar();
            llamaProcAlmacenado.Parameters.Clear();
            con.CerrarConexion();

            int resultado = (int)valor;

            return resultado;

        }
        #endregion

        #region GetNombreRol

        public string GetNombreRol(int IdRol) { 

            SqlCommand llamaProcAlmacenado = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_P_NombreRol",
                CommandType = CommandType.StoredProcedure
            };

            llamaProcAlmacenado.Parameters.AddWithValue("@IdRol", IdRol);
            object valor = llamaProcAlmacenado.ExecuteScalar();
            llamaProcAlmacenado.Parameters.Clear();
            con.CerrarConexion();

            string resultado = (string)valor;

            return resultado;


        }
        #endregion


        #region NombreRol

        public CE_Privilegios NombreRol(int IdRol)
        {

            SqlDataAdapter da = new SqlDataAdapter("SP_P_NombreRol", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdRol", SqlDbType.Int).Value = IdRol;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;

            dt= ds.Tables[0];

            DataRow row = dt.Rows[0];
            ce.NombreRol = Convert.ToString(row[0]);

            return ce;

        }
        



        #endregion

        #region Listar Roles

        public List<string> ObtenerPrivilegios()
        {
            SqlCommand llamaProcAlm = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_P_CargarRoles",
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = llamaProcAlm.ExecuteReader();

            List<string> lista = new List<string>();

            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["NombreRol"]));
            }

           con.CerrarConexion();

            return lista;
        }

        #endregion
    }
}
