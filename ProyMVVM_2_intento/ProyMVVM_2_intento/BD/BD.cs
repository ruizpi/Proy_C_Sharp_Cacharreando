using ProyMVVM_2_intento.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Navigation;
using System.Security.Cryptography;

namespace ProyMVVM_2_intento.BD
{
    internal class BD
    {
        private readonly string _conexion;

        public string Conexion { get { return _conexion; } }

        public BD()
        {
            _conexion = "Server=localhost;Database=BDUSERS;Trusted_Connection=True;";  
        }

        internal ObservableCollection<UserModel> Get()
        {
            ObservableCollection<UserModel> lstResult= new ObservableCollection<UserModel>();
            string query = "select * from usuarios";

            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lstResult.Add(new UserModel()
                    {
                        Id = (int)reader["IDUSER"],
                        Nombre = (string)reader["NOMBRE"],
                        Apellidos = (string)reader["APELLIDOS"],
                        Email = (string)reader["EMAIL"],
                        Password = (string)reader["CONTRASENA"]

                    });
                }
                reader.Close();
            }
            return lstResult;
        }

        public void Add(UserModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("model");
            }
            else
            {
                string query = "insert into usuarios values (@id, @name, @lastname, @password)";

                using (SqlConnection cn = new SqlConnection(Conexion))
                {
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("id", model.Id);
                    cmd.Parameters.AddWithValue("name", model.Nombre);
                    cmd.Parameters.AddWithValue("lastname", model.Apellidos);
                    cmd.Parameters.AddWithValue("password", model.Password);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }

        public void Delete(UserModel model) {

            string query = "delete from usuarios where IDUSER=@id";
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("id", model.Id);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void Edit(UserModel model)
        {

            string query = "update from usuarios set NOMBRE=@name, APELLIDOS=@apellidos, EMAIL=@email, CONTRASENA=@contrasena where IDUSER=@id";
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("id", model.Id);
                cmd.Parameters.AddWithValue("name", model.Nombre);
                cmd.Parameters.AddWithValue("apellidos", model.Apellidos);
                cmd.Parameters.AddWithValue("email", model.Email);
                cmd.Parameters.AddWithValue("contrasena", model.Password);

                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

    }
}
