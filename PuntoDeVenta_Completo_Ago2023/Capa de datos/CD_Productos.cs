using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Entidad;
using Capa_de_datos;
using System.Drawing;

namespace Capa_de_datos
{
    public class CD_Productos
    {
        CD_Conexion con = new CD_Conexion();    
        CE_Productos ce_prod = new CE_Productos();

        #region Buscar
            
        public DataTable Buscar(string buscar)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_A_Buscar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@Nombre",SqlDbType.VarChar).Value = buscar;
            
            DataSet ds = new DataSet();
            ds.Clear();

            da.Fill(ds);

            DataTable dt;

            dt=ds.Tables[0];

            con.CerrarConexion();

            return dt;
        }

        #endregion

        #region Consulta
        public CE_Productos Consulta(int IdProducto)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_A_Consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdArticulo", SqlDbType.Int).Value = IdProducto;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            
            ce_prod.Nombre = Convert.ToString(row[1]);
            ce_prod.IdGrupo = Convert.ToInt32(((int)row[2]).ToString());
            ce_prod.Codigo = Convert.ToString(row[3]);
            ce_prod.Precio = Decimal.Parse(row[4].ToString());  

            ce_prod.Activo = Convert.ToBoolean(row[5]);
            ce_prod.Cantidad = Decimal.Parse(row[6].ToString());  
            ce_prod.UnidadMedida = Convert.ToString(row[7]);
            ce_prod.Img = (byte[])row[8];
            ce_prod.Descripcion = Convert.ToString(row[9]);

            return ce_prod;


        }
        #endregion

        #region Insertar
            
        public void CD_Insertar(CE_Productos productos)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_A_Insertar",
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@Nombre", productos.Nombre);
            com.Parameters.AddWithValue("@IdGrupo", productos.IdGrupo);
            com.Parameters.AddWithValue("@Codigo", productos.Codigo);
            com.Parameters.AddWithValue("@Precio", productos.Precio);
            com.Parameters.AddWithValue("@Cantidad", productos.Cantidad);
            com.Parameters.AddWithValue("@Activo", productos.Activo);
            com.Parameters.AddWithValue("@UnidadMedida", productos.Activo);
            com.Parameters.AddWithValue("@Img", productos.Img);
            com.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
            com.ExecuteNonQuery();
            con.CerrarConexion();

        }



        #endregion

        # region Eliminar

        public void CD_Eliminar(CE_Productos productos)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),   
                CommandText = "SP_A_Eliminar",
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@IdArticulo", productos.IdArticulos);
            com.ExecuteNonQuery() ;
            com.Parameters.Clear();
            con.CerrarConexion() ;


        }

        #endregion

        #region Actualizar

        public void CD_Actualizar(CE_Productos productos)
        {


            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_A_Actualizar",
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.Add("@IdArticulo",SqlDbType.Int).Value = productos.IdArticulos;

            com.Parameters.AddWithValue("@Nombre", productos.Nombre);
            com.Parameters.AddWithValue("@IdGrupo", productos.IdGrupo);
            com.Parameters.AddWithValue("@Codigo", productos.Codigo);
            com.Parameters.Add("@Precio",SqlDbType.Decimal).Value = productos.Precio;
            com.Parameters.Add("@Cantidad",SqlDbType.Decimal).Value = productos.Cantidad;
            com.Parameters.AddWithValue("@Activo", productos.Activo);
            com.Parameters.AddWithValue("@UnidadMedida", productos.UnidadMedida);
            com.Parameters.AddWithValue("@Descripcion", productos.Descripcion);
            com.ExecuteNonQuery();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar IMG

        public void CD_ActualizarImg(CE_Productos productos)
        {

            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_A_ActualizarIMG",
                CommandType = CommandType.StoredProcedure
            };

            com.Parameters.AddWithValue("@IdArticulo", productos.IdArticulos.ToString());

            com.Parameters.AddWithValue("@Img", productos.Img);
         
            com.ExecuteNonQuery();
            con.CerrarConexion();

        }


        #endregion


    }
}
