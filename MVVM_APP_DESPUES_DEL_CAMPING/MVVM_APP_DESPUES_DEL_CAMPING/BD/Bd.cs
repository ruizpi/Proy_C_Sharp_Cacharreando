using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MVVM_APP_DESPUES_DEL_CAMPING.Models;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Reflection;
using System.Windows.Markup;

namespace MVVM_APP_DESPUES_DEL_CAMPING.BD
{
    internal class Bd
    {
        private readonly string _conexion;

        public string Conexion
        {
            get => _conexion; 
        }
        


        public Bd() {

            _conexion = "Server = localhost; Database = BDUSERS; Trusted_Connection = True;";
        }

        internal ObservableCollection<UserModel> Get()
        {
            ObservableCollection<UserModel> lstResult =  new ObservableCollection<UserModel>();

            string query = "Select * from usuarios";

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
                    }) ; 
                }
            }

            return lstResult;
        }

        internal void Add (UserModel user) {

            string query = "insert into usuarios values (@nombre,@apellidos,@email,@password);";
            using (SqlConnection cn = new SqlConnection (Conexion)) { 
                
                cn.Open();
                SqlCommand cmd = new SqlCommand (query, cn);
                cmd.Parameters.AddWithValue("@nombre",user.Nombre);
                cmd.Parameters.AddWithValue("@apellidos", user.Apellidos);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@password", user.Password);

                cmd.ExecuteNonQuery();
                cn.Close();

            }
        
        }

        internal void Delete(UserModel user) {
            string query = "delete from usuarios where IDUSER=@id";
            using (SqlConnection cn = new SqlConnection(Conexion))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        internal void Edit(UserModel user)
        {
            string queryPrincipal = "";
          

            string actualizacionFinal = DeterminaParamUpdate(queryPrincipal, user);

            if (actualizacionFinal != "")
            {
                using (SqlConnection cn = new SqlConnection(Conexion))
                {

                    cn.Open();
                    SqlCommand cmd = new SqlCommand(actualizacionFinal, cn);
             
                    cmd.ExecuteNonQuery();
                    cn.Close();

                }
            }


        }

        internal string DeterminaParamUpdate(string queryPrincipal, UserModel user)
        {
            string filtroId = " WHERE IDUSER=";
            string campos_A_Act = "";

            foreach (PropertyInfo propertyInfo in user.GetType().GetProperties())
            {

                if (propertyInfo.PropertyType == typeof(string))
                {
                    
                    string value = (string)propertyInfo.GetValue(obj: user);

                    if ((value != "") && (value!=null))
                    {

                        switch (propertyInfo.Name)
                        {
                            case "Nombre":
                                campos_A_Act = campos_A_Act + $" NOMBRE='{value}',";
                                break;
                            case "Apellidos":
                                campos_A_Act = campos_A_Act + $" APELLIDOS='{value}',";
                                break;
                            case "Email":
                                campos_A_Act = campos_A_Act + $" EMAIL='{value}',";
                                break;
                            case "Password":
                                campos_A_Act = campos_A_Act + $" CONTRASENA='{value}',";
                                break;
                        }
                    }

                }

                if (propertyInfo.PropertyType == typeof(int))
                {
                    int value = (int)propertyInfo.GetValue(obj: user);
                    if ((value != 0) && (value != null)) filtroId = filtroId + value;

                }
            }

            if ((campos_A_Act.Length > 0) && (filtroId.Length>0))
            {
                campos_A_Act = campos_A_Act.Substring(0, campos_A_Act.Length - 1);
                queryPrincipal = "UPDATE usuarios SET " + campos_A_Act + filtroId;
            }

            

            return queryPrincipal;

        }


    }
}
