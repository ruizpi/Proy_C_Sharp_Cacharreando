using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;
using Capa_de_datos;
using Capa_Criptografica;

namespace Capa_de_datos
{
    public class CD_Usuarios
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Usuarios ce = new CE_Usuarios();
        


        #region INSERTAR
        public void CD_Insertar(CE_Usuarios Usuarios)
        {

 

            SqlCommand llamaProcedimiento2 = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_Insertar",
                CommandType = CommandType.StoredProcedure
            };
            llamaProcedimiento2.Parameters.AddWithValue("@Nombre", Usuarios.Nombre);
            llamaProcedimiento2.Parameters.AddWithValue("@Apellidos", Usuarios.Apellidos);
            llamaProcedimiento2.Parameters.AddWithValue("@DNI", Usuarios.Dni);
            llamaProcedimiento2.Parameters.AddWithValue("@Email", Usuarios.Email);
            llamaProcedimiento2.Parameters.AddWithValue("@Tlf", Usuarios.Tlf);
            llamaProcedimiento2.Parameters.Add("@FechaNac", SqlDbType.Date).Value=Usuarios.FechaNac;
            llamaProcedimiento2.Parameters.AddWithValue("@IdRol", Usuarios.IdRol);
            llamaProcedimiento2.Parameters.AddWithValue("@Img",Usuarios.Img);
            llamaProcedimiento2.Parameters.AddWithValue("@Usuario", Usuarios.Usuario);             
            llamaProcedimiento2.Parameters.AddWithValue("@Patron", Usuarios.Patron);

            string encriptado = Seguridad.Encrypt(Usuarios.Contrasena.ToString(), Usuarios.Patron);


            string comprueba = Seguridad.Decrypt(encriptado, Usuarios.Patron);

            llamaProcedimiento2.Parameters.AddWithValue("@Contrasena",encriptado);
            
            


            llamaProcedimiento2.ExecuteNonQuery();
            llamaProcedimiento2.Parameters.Clear();
            con.CerrarConexion();

        }

        #endregion

        #region CONSULTAR

        // es CE_Usuarios porque es la entidad (una fila) cargada de datos lo que hay que devolver
        public CE_Usuarios Consulta(int IdUsuario)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = IdUsuario;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Nombre = Convert.ToString(row[1]);
            ce.Apellidos = Convert.ToString(row[2]);
            ce.Dni = Convert.ToString(row[3]);
            ce.Email = Convert.ToString(row[4]);
            ce.Tlf = Convert.ToInt32(row[5]);
            ce.FechaNac = Convert.ToDateTime(row[6]);
            ce.IdRol = Convert.ToInt32(row[7]);
            ce.Img = (byte[])row[8];
            ce.Usuario = Convert.ToString(row[9]);  

            return ce;
        }

        #endregion

        #region ELIMINAR

        public void CD_Eliminar(CE_Usuarios Usuarios)
        {
            SqlCommand llamaProcedimient = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_Eliminar",
                CommandType = CommandType.StoredProcedure
            };


            llamaProcedimient.Parameters.AddWithValue("@IdUsuario", Usuarios.IdUsuario);
            llamaProcedimient.ExecuteNonQuery();
            llamaProcedimient.Parameters.Clear();
            con.CerrarConexion();
        }


        #endregion

        #region Actualizar Datos

        public void CD_ActualizarDatos(CE_Usuarios Usuarios)
        {
            SqlCommand llamaProcedimiento = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText="SP_U_ActualizarDatos",
                CommandType = CommandType.StoredProcedure
            };

            llamaProcedimiento.Parameters.AddWithValue("@IdUsuario", Usuarios.IdUsuario);
            llamaProcedimiento.Parameters.AddWithValue("@Nombre", Usuarios.Nombre);
            llamaProcedimiento.Parameters.AddWithValue("@Apellidos", Usuarios.Apellidos);
            llamaProcedimiento.Parameters.AddWithValue("@Dni", Usuarios.Dni);
            llamaProcedimiento.Parameters.AddWithValue("@Email", Usuarios.Email);
            llamaProcedimiento.Parameters.AddWithValue("@Tlf", Usuarios.Tlf);
            llamaProcedimiento.Parameters.Add("@FechaNac", SqlDbType.Date).Value = Usuarios.FechaNac;
            llamaProcedimiento.Parameters.AddWithValue("@IdRol", Usuarios.IdRol);           
            llamaProcedimiento.Parameters.AddWithValue("@Usuario", Usuarios.Usuario);




            llamaProcedimiento.ExecuteNonQuery();
            llamaProcedimiento.Parameters.Clear();
            con.CerrarConexion();



        }

        #endregion

        #region Actualizar PASS

        public void CD_ActualizarPass(CE_Usuarios Usuarios)
        {
            SqlCommand llamaProcedimiento = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText="SP_U_ActualizarPass",
                CommandType = CommandType.StoredProcedure
            };
            llamaProcedimiento.Parameters.AddWithValue("@IdUsuario", Usuarios.IdUsuario);

            string encriptado = Seguridad.Encrypt(Usuarios.Contrasena.ToString(), Usuarios.Patron);

            llamaProcedimiento.Parameters.AddWithValue("@Contrasena", encriptado);


          //  llamaProcedimiento.Parameters.AddWithValue("@Contrasena", Usuarios.Contrasena);
            llamaProcedimiento.Parameters.AddWithValue("@Patron", Usuarios.Patron);
            llamaProcedimiento.ExecuteNonQuery();
            llamaProcedimiento.Parameters.Clear();
            con.CerrarConexion();
        }

        #endregion

        #region Actualizar IMG

        public void CD_ActualizarIMG(CE_Usuarios Usuarios)
        {
            SqlCommand llamaProcedimiento = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_ActualizarIMG",
                CommandType = CommandType.StoredProcedure
            };
            llamaProcedimiento.Parameters.AddWithValue("@IdUsuario", Usuarios.IdUsuario);
            llamaProcedimiento.Parameters.AddWithValue("@IMG", Usuarios.Img);
            llamaProcedimiento.ExecuteNonQuery();
            llamaProcedimiento.Parameters.Clear();
            con.CerrarConexion();
        }

        #endregion

        /*
         * CON BUSCAR USUARIOS ES SUFICIENTE PARA CUBRIR ESTA FUNCION Y EN EL PROCEDIMIENTO ALMACENADO TAMBIEN SOBRARÍA
         * 
        #region CargarUsuarios
        public DataTable CargarUsuarios()
        {
            SqlDataAdapter da =  new SqlDataAdapter("SP_U_CargarUsuarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure; 
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion
        */


        #region BuscarUsuario
        public DataTable Buscar(string busqueda)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Buscar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@buscar",SqlDbType.VarChar).Value = busqueda;
            
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion


        #region LOGIN
        public CE_Usuarios Login(string usuario, string contrasena)
        {

            //SqlDataAdapter da = new SqlDataAdapter("SP_U_Validar", con.AbrirConexion());
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
            //valorEncriptacion = Seguridad.Encrypt(contrasena, patron);
            //da.SelectCommand.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = valorEncriptacion;


            SqlDataAdapter da = new SqlDataAdapter("SP_U_GetPasswordEnc",con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
            //valorEncriptacion = Seguridad.Encrypt(contrasena, patron);
            //da.SelectCommand.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = valorEncriptacion;


            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow row;

            if ( dt.Rows.Count > 0 )
            {
                row = dt.Rows[0];


                string passDesencriptada = Seguridad.Decrypt(Convert.ToString(row[0]), Seguridad.Patron);

                if (passDesencriptada.Equals(contrasena))
                {
                    ce.IdUsuario = Convert.ToInt32(row[1]);
                    ce.IdRol = Convert.ToInt32(row[2]);
                }
                
            }





            return ce;
        }
        #endregion




    }
}
