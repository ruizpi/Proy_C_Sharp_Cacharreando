using MVVM_01.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_01.BD
{
    internal class DataBase
    {
        private readonly string _conexion;

        public string Conexion => _conexion;

        public DataBase() {

            _conexion = @"Server=AVEFENIX;Database=BDUSERS; Trusted_Connection=true;";
        
        }
        internal ObservableCollection<UserModel> Get()
        {
            ObservableCollection<UserModel> lstResultado = new ObservableCollection<UserModel>();
            string query = "select * from Usuarios";


            using (SqlConnection con = new SqlConnection(Conexion)) 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    lstResultado.Add(new UserModel()
                    {
                        Id = (int)reader["IDUSER"],
                        Nombre = (string)reader["NOMBRE"],
                        Apellidos = (string)reader["APELLIDOS"],
                        Email = (string)reader["EMAIL"],
                        Password = (string)reader["CONTRASENA"],
                    });
                   ;
                }
                reader.Close();
                con.Close();
            }
            

            return lstResultado;

                
        }

        internal void Add(UserModel user)
        {
            string query = "insert into user values (@Id, @nombre, @apellidos, @email, @contrasena);";
            using(SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", user.Apellidos);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@contrasena", user.Password);

                cmd.ExecuteNonQuery();
                con.Close();

            }

        }

        internal void Delete(UserModel user)
        {
            string query = "delete from user where IDUSER=@Id;";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        internal void Edit(UserModel user)
        {
            string query = "update user set NOMBRE=@nombre, APELLIDOS=@apellidos, EMAIL=@email, CONTRASENA=@contrasena where IDUSER=@Id;";
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@nombre", user.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", user.Apellidos);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@contrasena", user.Password);

                cmd.ExecuteNonQuery();
                con.Close();

            }

        }
    }
}
