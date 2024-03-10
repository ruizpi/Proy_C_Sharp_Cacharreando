using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Data;

namespace Capa_de_datos
{
    public class CD_Dashboard
    {
        CD_Conexion conexion = new CD_Conexion();
        #region CANTIDAD VENTAS
        public int CantidadVentas()
        {

            int total;
            SqlCommand procAlm = new SqlCommand("SP_D_CantidadVentas", conexion.AbrirConexion());
            procAlm.CommandType = CommandType.StoredProcedure;
            total = (int)procAlm.ExecuteScalar();   

            return total;

        }
        #endregion


        #region ARTICULOS VENDIDOS
        public decimal Articulos()
        {
            SqlCommand procAlm = new SqlCommand("SP_D_Articulos", conexion.AbrirConexion());
            procAlm.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = procAlm.ExecuteReader();
            decimal total;
            rd.Read();
            total = (decimal)rd[0];
            rd.Close();
            conexion.CerrarConexion();

            return total;
        }

        #endregion


        #region GRAFICO
        public DataTable Grafico()
        {

            SqlDataAdapter procAlm = new SqlDataAdapter("SP_D_Grafico", conexion.AbrirConexion());
            procAlm.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            procAlm.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            conexion.CerrarConexion();

            return dt;
        }


        #endregion
    }
}
