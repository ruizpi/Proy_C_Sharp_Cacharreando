using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Microsoft.SqlServer.Server;

namespace Negocios
{
    public class ConexNegocio
    {

        ConexionSQL cn = new ConexionSQL();

        public int conSQL (string user, string pass)
        {
            return cn.consultalogin (user, pass);   
        }

        public int InsPersona(string nombre, string apellidos, string dni, string telefono, string usuario, string pass)
        {
            return cn.insertaUsuario(nombre, apellidos, telefono, dni, usuario, pass);
        }

        public void InsFacturaNeg(List<Factura> F)
        {
            cn.InsertarFactura(F);  
        }

        public DataTable ConsultaEnNegocio (string sql)
        {
            DataTable dt = new DataTable();

            dt = cn.ConsultaEnDatos(sql);

            return dt;
        }

        public Tuple<string, double> ObtieneCliente(string codcliente)
        {
            return cn.ObtieneCliente (codcliente);
        }


        public DataTable DatosGraficaNeg()
        {
            return cn.DatosGrafica();
        }


        public Tuple<string,string> consultainventario(string codigo)
        {
            return cn.consultainventario(codigo);
        }

        public string DaUltimoValorSegunCampo(string tabla, string campo) 
        {
            return cn.DaUltimoValorSegunCampo(tabla, campo);
        }
    }
}
