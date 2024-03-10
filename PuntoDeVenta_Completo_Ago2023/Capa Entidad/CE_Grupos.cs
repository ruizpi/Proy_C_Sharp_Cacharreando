using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Grupos
    {
        private int _Id;
        private string _NomGrupo;

        public int Id { get => _Id; set => _Id = value; }
        public string NomGrupo { get => _NomGrupo; set => _NomGrupo = value; }
    }
}
