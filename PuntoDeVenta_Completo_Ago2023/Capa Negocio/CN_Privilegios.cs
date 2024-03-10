using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_de_datos;
using System.Runtime.Remoting.Messaging;

namespace Capa_Negocio
{
    public class CN_Privilegios
    {
        CD_Privilegios CD_Privilegios = new CD_Privilegios();
        

        #region IdRol
        public int IdRol(string NombreRol)
        {
            return CD_Privilegios.IdRol(NombreRol);

        }
        #endregion

        #region NombreRol
        public CE_Privilegios NombreRol(int IdRol)
        {
            return CD_Privilegios.NombreRol(IdRol);
        }
        #endregion


        public List<string> ObtenerRoles()
        {
            List<string> roles = new List<string>();

            roles = CD_Privilegios.ObtenerPrivilegios();
             
            return roles;
        }

        public string GetNombreRol(int IdRol) {

            string nombreRol = CD_Privilegios.GetNombreRol(IdRol);

            return nombreRol;
        }
    }
}
