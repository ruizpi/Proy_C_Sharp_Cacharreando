using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegClientes
    {
        public static List<Datos.Clientes> getClientes(String filtroNombre="", String filtroApellidos="", String filtroTelefono="")
        {


            using (Datos.PuntodeVentaEntities db = new Datos.PuntodeVentaEntities())
            {
                
                
                

                List<Datos.Clientes> clientesFiltros = db.Clientes.ToList();


                if (filtroNombre != "")
                {
                    //CriteriosVarios.Add(reg => reg.Equals(filtroNombre));
                    //cadena = String.Format("NombreCliente=@0", filtroNombre);
                    clientesFiltros = clientesFiltros.Where(p => p.NombreCliente == filtroNombre).ToList(); 
                }
                   
                if (filtroApellidos != "")
                {
                    clientesFiltros = clientesFiltros.Where(p => p.ApellidoCliente == filtroApellidos).ToList();
     
                }

                if (filtroTelefono != "")
                {
                    clientesFiltros = clientesFiltros.Where(p => p.Telefono == filtroTelefono).ToList();

                }

                //resultado =  db.Clientes.Where(reg => reg.NombreCliente == filtroNombre &&
                //                                        reg.ApellidoCliente == filtroApellidos &&
                //                                        reg.Telefono == filtroTelefono).ToList();
                return clientesFiltros;

                
            }
        }


        public static List<Datos.vCliFactu> getDatosFacturacion(String filtroNombre = "", String filtroApellidos = "", String filtroCodigoProducto = "")
        {
            List<Datos.vCliFactu> filtroDatosFacturacion;

            using (Datos.PuntodeVentaEntities db = new Datos.PuntodeVentaEntities())
            {

                filtroDatosFacturacion = db.vCliFactu.ToList();

                if (filtroNombre != "")
                {
                    filtroDatosFacturacion = filtroDatosFacturacion.Where(registro => registro.NombreCliente.Equals(filtroNombre)).ToList();

                }
                if (filtroApellidos != "")
                {
                    filtroDatosFacturacion = filtroDatosFacturacion.Where(registro => registro.ApellidoCliente.Equals(filtroApellidos)).ToList();

                }
                if (filtroCodigoProducto != "")
                {
                    filtroDatosFacturacion = filtroDatosFacturacion.Where(registro => registro.Codigo.Equals(filtroCodigoProducto)).ToList();

                }
            }


            return filtroDatosFacturacion;
        }

    }
}
