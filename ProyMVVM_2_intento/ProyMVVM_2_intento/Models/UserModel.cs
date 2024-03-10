using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyMVVM_2_intento.Models
{
    public class UserModel
    {
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _password;
        private int _id;

        public int Id
        {
            get { return _id; }
            set {
                if (_id != value)
                {
                    _id = value;
                }
                
            }
        }
        
        
        public string Nombre
        {
            get => _nombre;
            set
            {
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
                if (value != _apellidos) 
                {
                    _apellidos = value;
                }
            }
        }
        public string Email { 
            get => _email;
            set { 
                if (_email != value)
                {
                    _email = value;
                }
            }
        }   
        public string Password { 
            get => _password;
            set { 
                if(value != _password)
                {
                    _password = value;
                }
            } 
        }    

        string GetNomCompleto()
        {
            string nomCompleto = _apellidos + " " +_nombre;
            return nomCompleto;
        }
         

    }
}
