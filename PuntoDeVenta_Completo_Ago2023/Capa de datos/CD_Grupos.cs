using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Capa_de_datos;
using Capa_Entidad;

namespace Capa_de_datos
{



    public class CD_Grupos
    {

        CD_Conexion con = new CD_Conexion();

        CE_Grupos cE_Grupos = new CE_Grupos();

        #region Listar Grupos
        public List<string> ListarGrupos()
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandType = CommandType.StoredProcedure,
                CommandText = "SP_G_CargarGrupos"
            };

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> retorno = new();
            while (reader.Read())
            {
                retorno.Add(Convert.ToString(reader["NomGrupo"]));
            }
            con.CerrarConexion();


            return retorno;
        }

        #endregion

        #region NombreGrupo



        public CE_Grupos Nombre(int IdGrupo)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_G_Nombre", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdGrupo", SqlDbType.Int).Value = IdGrupo;

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            cE_Grupos.NomGrupo = Convert.ToString(row[0]);

            return cE_Grupos;
        }
        #endregion

        #region IdGrupo
        public int IdGrupo(string NomGrupo)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandType = CommandType.StoredProcedure,
                CommandText = "SP_G_IdGrupo"
            };
            com.Parameters.AddWithValue("@NombreGrupo", NomGrupo);

            object valor = com.ExecuteScalar();
            int idgrupo = (int)valor;
            con.CerrarConexion();

            return idgrupo;

        }

        #endregion


    }
}

