using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_01.Model
{
    public class UserModel
    {
        private int _Id;
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _password;

        public string Nombre { 
            get => _nombre; 
            set{

                if (_nombre != value)
                {
                    _nombre = value;
                }

            } 
        }
        public string Apellidos
        {
            get => _apellidos;
            set
            {
                if (_apellidos != value)
                {
                    _apellidos = value;
                }

            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                }
            }
        }
        public string Password { 
            get => _password;
            set
            {
                if (value != _password)
                {
                    _password = value;
                }
            }  
        }

        public int Id { get => _Id; set => _Id = value; }
    }
}
