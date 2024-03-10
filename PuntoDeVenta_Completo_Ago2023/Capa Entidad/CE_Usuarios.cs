using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Usuarios
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _Apellidos;
        private string _Dni;
        private string _Email;
        private int _Tlf;
        private DateTime _FechaNac;
        private int _IdRol;
        private byte[] _Img;
        private string _usuario;
        private string _contrasena;
        private string _patron;



        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Dni { get => _Dni; set => _Dni = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int Tlf { get => _Tlf; set => _Tlf = value; }
        public DateTime FechaNac { get => _FechaNac; set => _FechaNac = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public byte[] Img { get => _Img; set => _Img = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public string Patron { get => _patron; set => _patron = value; }
    }
}
