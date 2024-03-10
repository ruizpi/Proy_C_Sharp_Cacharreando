using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocios
{
    public class Clientes
    {
        public static List<Datos.Clientes> Get()
        {


            using (Datos.PuntodeVentaEntities db = new Datos.PuntodeVentaEntities())
            {
                return db.Clientes.ToList();
            }
        }



    }
}
