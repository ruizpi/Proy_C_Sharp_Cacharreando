using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Privilegios
    {
        private int _IdRol;
        private string _NombreRol;

        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string NombreRol { get => _NombreRol; set => _NombreRol = value; }
    }
}
