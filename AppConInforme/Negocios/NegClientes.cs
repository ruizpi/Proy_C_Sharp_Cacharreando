using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegClientes
    {
        public static List<Datos.Clientes> getClientes()
        {
            using(Datos.PuntodeVentaEntities db = new Datos.PuntodeVentaEntities())
            {
                return db.Clientes.ToList();
            }
        } 

    }
}
