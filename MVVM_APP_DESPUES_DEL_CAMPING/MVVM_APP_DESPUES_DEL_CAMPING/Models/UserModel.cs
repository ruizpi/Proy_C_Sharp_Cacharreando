using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_APP_DESPUES_DEL_CAMPING.Models
{
    public class UserModel
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _password;

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                }
            }
        }
        public string Nombre { get => _nombre;
            set
            {
                if (value != null)
                {
                    _nombre = value;
                }
            }             
        }

        public string Apellidos { get => _apellidos;
            set { 
                if (value != null)
                {
                     _apellidos = value;
                }
            } 
        }

        public string Email { get => _email;
            set
            {
                if (value != null)
                {
                    _email = value;
                }
                   
            } 
        }

        public string Password { get => _password;
            set {
                if (value != null)
                {
                    _password = value;
                }
            }
        }
    }
}
