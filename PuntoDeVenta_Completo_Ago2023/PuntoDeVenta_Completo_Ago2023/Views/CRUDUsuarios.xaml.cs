using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// esto es para poder enlazar con la capa de negocios y Entidades
using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Runtime.CompilerServices;
using Capa_Criptografica;
using PuntoDeVenta_Completo_Ago2023.Recursos.WindAdicionales;

namespace PuntoDeVenta_Completo_Ago2023.Views
{
    /// <summary>
    /// Lógica de interacción para CRUDUsuarios.xaml
    /// </summary>
    public partial class CRUDUsuarios : Page
    {

        readonly CN_Usuarios objeto_CN_Usuarios = new CN_Usuarios();
        readonly CE_Usuarios objeto_CE_Usuarios = new CE_Usuarios();
        readonly CN_Privilegios objeto_CN_Roles = new CN_Privilegios();

        public int IdUsuario;
        // EL PATRON EN AES MINIMO DEBE DE SER FIJO DE 8 CARACTERES PARA QUE LA CLAVE DE ENCRIPTACION INTERNA SEA 64 BITS
       // public string Patron = "44038930440389304403893044038930";

        string Patron = Seguridad.Patron;

        Error WndError;



        #region INICIAL
        public CRUDUsuarios()
        {
            InitializeComponent(); 
            CargarCB();
        }
        #endregion

        #region VOLVER
        private void VolverMain(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }
        #endregion



        // QUITAMOS ESTO PORQUE YA TENEMOS LA CLASE DATOS CON LA CONEXION, ESTO FUE UTILIZADO INICIALMENTE
        //readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString);

        //#region CARGARROLES
        //void CargarRoles()
        //{
        //  //  con.Open();
        //    //SqlCommand cmd = new SqlCommand("select NombreRol from Roles order by NombreRol", con);
        //    //SqlDataReader reader = cmd.ExecuteReader();
        //    //while (reader.Read())
        //    //{
        //    //    cbRoles.Items.Add(reader["NombreRol"].ToString());
        //    //}
        //    //con.Close();

        //}
        //#endregion

        #region CARGARCB
        void CargarCB()
        {
            //ListBox<string> roles = objeto_CN_Roles.ObtenerRoles();
            //for(int i = 0; i < roles.Count; i++)
            //{
            //    cbPrivilegio.Items.Add(roles[i]);   
            //}
            try
            {
                cbRoles.Items.Clear();
                cbRoles.ItemsSource = objeto_CN_Roles.ObtenerRoles();
            }
            catch(Exception ex)
            {
                Error WndError = new Error();
                WndError.lblError.Text = ex.Message;
                WndError.ShowDialog();
            }


        }


        #endregion

        #region ValidarCamposVacios

        public bool CamposLlenos()
        {
            if (tbNombres.Text == "" || tbApellidos.Text == "" || tbDNI.Text == "" || tbEMAIL.Text == "" || tbFECHNAC.Text == "" || tbTLF.Text == "" || tbUsuario.Text == "" || cbRoles.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        #endregion




        #region CRUD (CREATE, READ, UPDATE, DELETE)

  


            #region CREATE

            private void CrearUsuario(object sender, RoutedEventArgs e)
            {
                if (CamposLlenos() == true && tbPassword.Text != "")
                {
                    try
                    {
                        int IdRol = 0;


                        IdRol = objeto_CN_Roles.IdRol(cbRoles.Text);
                        objeto_CE_Usuarios.Nombre = tbNombres.Text;
                        objeto_CE_Usuarios.Apellidos = tbApellidos.Text;
                        objeto_CE_Usuarios.Dni = tbDNI.Text;
                        objeto_CE_Usuarios.Email = tbEMAIL.Text;
                        objeto_CE_Usuarios.Tlf = int.Parse(tbTLF.Text);

                        objeto_CE_Usuarios.FechaNac = DateTime.Parse(tbFECHNAC.Text);
                        objeto_CE_Usuarios.Img = data;
                        objeto_CE_Usuarios.Patron = Patron;
                        objeto_CE_Usuarios.IdRol = IdRol;
                        objeto_CE_Usuarios.Usuario = tbUsuario.Text;
                        objeto_CE_Usuarios.Contrasena = tbPassword.Text;

                        objeto_CN_Usuarios.Insertar(objeto_CE_Usuarios);

                        Content = new Usuarios();
                    }
                    catch (Exception ex) 
                    {
                        Error WndError = new Error();
                        WndError.lblError.Text = ex.Message.ToString();
                        WndError.ShowDialog();
                    }
                }
                else
                {
                    Error WndError = new Error();
                    WndError.lblError.Text = "Los campos no pueden quedar vacíos";
                    WndError.ShowDialog();
                  //  MessageBox.Show("Los campos no pueden quedar vacíos");
                }


        // ESTE CODIGO FUE EL PRIMERO QUE SE HIZO
        //    // EL CAMPO , Contrasena=(EncryptByPassPhrase('" + patron + "','" + tbPassword.Text + "')) N SE VA A COMPROBAR Y SE DEJARÁ EN BLANCO PARA NO MOSTRAR LA PASSWORD 
        //    // SOLO EN EL CASO DE QUE UNO RELLENE EL CAMPO ENTONCES CAMBIARÁ, ESTO ES POR MEDIDA DE SEGURIDAD

        //    if (tbNombres.Text=="" || tbApellidos.Text=="" || tbDNI.Text=="" || tbEMAIL.Text=="" || tbFECHNAC.Text=="" || tbTLF.Text=="" ||  tbUsuario.Text == "" || cbRoles.Text=="")
        //        {
        //            MessageBox.Show("Los campos no pueden quedar vacios");
        //        }
        //        else
        //        {
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand($"select IdRol from Roles where NombreRol='{cbRoles.Text}'", con);
        //            object valor = cmd.ExecuteScalar();
        //            int idRol = (int)valor;
        //            string patron = "44038930W";

        //            if (imagenSubida == true)
        //            {
        //                SqlCommand command = new SqlCommand("insert into Usuarios (Nombre, Apellidos, Dni, Email, Tlf, FechaNac, IdRol, Img, Usuario, Contrasena) values (@nombre, @apellidos, @dni, @email, @tlf, @fechanac, @idrol, @img, @usuario, (EncryptByPassPhrase('" + patron + "','" + tbPassword.Text + "')))", con);
        //                command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tbNombres.Text;
        //                command.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = tbApellidos.Text;
        //                command.Parameters.Add("@dni", SqlDbType.VarChar).Value = tbDNI.Text;
        //                command.Parameters.Add("@email", SqlDbType.VarChar).Value = tbEMAIL.Text;
        //                command.Parameters.Add("@tlf", SqlDbType.Int).Value = int.Parse(tbTLF.Text);
        //                command.Parameters.Add("@fechanac", SqlDbType.Date).Value = tbFECHNAC.Text;
        //                command.Parameters.Add("@idrol", SqlDbType.Int).Value = idRol;
        //                command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tbUsuario.Text;
        //                command.Parameters.Add("@img", SqlDbType.VarBinary).Value = data;
        //                command.ExecuteNonQuery();
        //                Content = new Usuarios();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Debe agregar una imagen");
        //            }

        //            con.Close();
        //        }


            }
            #endregion
            #region READ
            
            public void Consultar()
            {
                try
                {
                    var a = objeto_CN_Usuarios.Consulta(IdUsuario);
                    tbNombres.Text = a.Nombre;
                    tbApellidos.Text = a.Apellidos;
                    tbDNI.Text = a.Dni;
                    tbEMAIL.Text = a.Email;
                    tbTLF.Text = a.Tlf.ToString();
                    tbFECHNAC.Text = a.FechaNac.ToString();
                    cbRoles.SelectedValue = objeto_CN_Roles.GetNombreRol(a.IdRol);

                    ImageSourceConverter img = new ImageSourceConverter();
                    imagen.Source = (ImageSource)img.ConvertFrom(a.Img);
                    tbUsuario.Text = a.Usuario;

                    data = a.Img;
                }
                catch(Exception ex)
                {
                    WndError = new Error();
                    WndError.lblError.Text = ex.Message.ToString();
                    WndError.ShowDialog();
                }



                

                
            
                




                /*
                 * ESTE CODIGO SE GENERÓ AL PRINCIPIO DEL PROYECTO
                 * 
                 * 
                con.Open();

                SqlCommand command = new SqlCommand("select * from Usuarios inner join Roles on Usuarios.IdRol=Roles.IdRol where IdUsuario=" + IdUsuario, con);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                reader.Read();

                this.tbNombres.Text = reader["Nombre"].ToString();
                this.tbApellidos.Text = reader["Apellidos"].ToString();
                this.tbDNI.Text = reader["Dni"].ToString();
                this.tbEMAIL.Text = reader["email"].ToString();
                this.tbTLF.Text = reader["tlf"].ToString();
                this.tbFECHNAC.Text = reader["FechaNac"].ToString();
                this.tbUsuario.Text = reader["Usuario"].ToString();

                // TEMPORALMENTE
                //VACIA
                this.tbPassword.Text = "";
                this.cbRoles.SelectedItem = reader["NombreRol"].ToString();

                reader.Close();


                // IMAGEN

                DataSet ds = new DataSet();
                SqlDataAdapter sqda = new SqlDataAdapter("Select Img from Usuarios where IdUsuario=" + IdUsuario, con);
                sqda.Fill(ds);
                byte[] data;

                data = (byte[])ds.Tables[0].Rows[0][0];
                MemoryStream strm = new MemoryStream();
                strm.Write(data, 0, data.Length);
                strm.Position = 0;
                System.Drawing.Image img = System.Drawing.Image.FromStream(strm);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);
                bi.StreamSource = ms;
                bi.EndInit();
                imagen.Source = bi;
                con.Close();
                */


            }
        #endregion
            #region UPDATE

            private void EditarUsuario(object sender, RoutedEventArgs e)
            {

                if (CamposLlenos())
                {
                    try
                    {
                        int IdRol = objeto_CN_Roles.IdRol(cbRoles.SelectedValue.ToString());

                        objeto_CE_Usuarios.IdUsuario = IdUsuario;
                        objeto_CE_Usuarios.Nombre = tbNombres.Text;
                        objeto_CE_Usuarios.Apellidos = tbApellidos.Text;
                        objeto_CE_Usuarios.Dni = tbDNI.Text;
                        objeto_CE_Usuarios.Email = tbEMAIL.Text;
                        objeto_CE_Usuarios.Tlf = int.Parse(tbTLF.Text);
                        objeto_CE_Usuarios.FechaNac = DateTime.Parse(tbFECHNAC.Text);
                        objeto_CE_Usuarios.IdRol = IdRol;
                        objeto_CE_Usuarios.Img = data;
                        objeto_CE_Usuarios.Usuario = tbUsuario.Text;
                        objeto_CN_Usuarios.ActualizarDatos(objeto_CE_Usuarios);
                        Content = new Usuarios();

                    }
                    catch(Exception ex) {
                        Error WndError = new Error();
                        WndError.lblError.Text = ex.Message.ToString();
                        WndError.ShowDialog();

                    }

                }
                else
                {
                   // MessageBox.Show("LOS CAMPOS NO DEBEN QUEDAR VACIOS");
                    Error WndError = new Error();
                    WndError.lblError.Text = "LOS CAMPOS NO DEBEN QUEDAR VACIOS";
                    WndError.ShowDialog();
                }


                // SI EL USUARIO LE HA DADO POR MODIFICAR EL CAMPO DE CONTRASENA
                if (tbPassword.Text != "")
                {
                    try
                    {
                        objeto_CE_Usuarios.IdUsuario = IdUsuario;
                        objeto_CE_Usuarios.Contrasena = tbPassword.Text;
                        objeto_CE_Usuarios.Patron = Patron;

                        objeto_CN_Usuarios.ActualizarPass(objeto_CE_Usuarios);
                        Content = new Usuarios();
                    }
                    catch(Exception ex)
                    {
                        Error WndError = new Error();
                        WndError.lblError.Text = ex.Message.ToString();
                        WndError.ShowDialog();
                }



                }

                if (imagenSubida == true)
                {
                    try
                    {
                        objeto_CE_Usuarios.IdUsuario = IdUsuario;
                        objeto_CE_Usuarios.Img = data;
                        objeto_CN_Usuarios.ActualizarIMG(objeto_CE_Usuarios);
                        Content = new Usuarios();
                    }
                    catch(Exception ex)
                    {
                        Error WndError = new Error();
                        WndError.lblError.Text = ex.Message.ToString();
                        WndError.ShowDialog();
                    }

                }

            /* ESTE ES EL CODIGO INICIAL QUE DESPUES NO SE UTILIZA POR LA CAPA DE NEGOCIO
             * 
                con.Open();
                SqlCommand com = new SqlCommand("select IdRol from Roles where NombreRol='"+cbRoles.Text+"'",con);
                object valor = com.ExecuteScalar();
                int idRol = (int)valor;

                string patron = "44038930W";

            // , Contrasena=(EncryptByPassPhrase('" + patron + "','" + tbPassword.Text + "'))

                SqlCommand cmd =  new SqlCommand("update usuarios set Nombre='"+tbNombres.Text+"', Apellidos='"+tbApellidos.Text+"', DNI='"+tbDNI.Text+"', EMail='"+tbEMAIL.Text+"', Tlf="+int.Parse(tbTLF.Text)+", FechaNac='"+tbFECHNAC.Text+"', IdRol="+ idRol+", Usuario='"+tbUsuario.Text+ "'", con);
                if (imagenSubida==true)
                {
                    SqlCommand img = new SqlCommand("update Usuarios set img=@img where IdUsuario='"+IdUsuario+"'",con);
                    img.Parameters.AddWithValue("@img", SqlDbType.VarBinary).Value = data;
                    img.ExecuteNonQuery();
                }
                cmd.ExecuteNonQuery();

            if (tbPassword.Text != "")
            {
                SqlCommand cmd2 = new SqlCommand("update Usuarios set Contrasena = (EncryptByPassPhrase('" + patron + "', '" + tbPassword.Text + "')) where IdUsuario="+IdUsuario, con);
                cmd2.ExecuteNonQuery();

            }




                con.Close() ;
                Content = new Usuarios();
            */

            }



        #endregion
            #region DELETE

                private void EliminarUsuario(object sender, RoutedEventArgs e)
                {

                    try
                    {
                        objeto_CE_Usuarios.IdUsuario = IdUsuario;
                        objeto_CN_Usuarios.Eliminar(objeto_CE_Usuarios);
                        Content = new Usuarios();
                    }
                    catch (Exception ex)
                    {
                        Error WndError = new Error();
                        WndError.lblError.Text = ex.Message;    
                        WndError.ShowDialog();
                    }






                    /*
                     * ESTO ES EL CODIGO ANTIGUO
                     * 
                     * 
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete from usuarios where IdUsuario=" + IdUsuario, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Content= new Usuarios();
                    */
                }

        #endregion

        #endregion




        #region IMAGEN

        byte[] data;
        private bool imagenSubida = false;
        private void CambiarImagen(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == true)
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    data = new byte[fs.Length];
                    fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                    fs.Close();

                    // ahora lo que se hace es cargar esa imagen en un componente image en XAML
                    ImageSourceConverter imgs = new ImageSourceConverter();

                    imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));
                }
                imagenSubida = true;
            }
            catch (Exception ex)
            {
                WndError = new Error();
                WndError.lblError.Text = ex.Message.ToString();
                WndError.ShowDialog();
            }

        }
        #endregion
    }
}
