using Capa_de_datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Carrito
    {

        readonly CD_Carrito objCarrito = new CD_Carrito();

        #region BUSCAR
        public CE_Carrito Buscar(string buscar)
        {
            return objCarrito.Buscar(buscar);
        }
        #endregion


        #region AGREGAR

        public DataTable Agregar (string producto, decimal cantidad)
        {
            return objCarrito.Agregar(producto, cantidad);
        }



        #endregion


        #region VENTA
        public void Venta (string factura, decimal total, DateTime fecha, int idUsuario)
        {
            objCarrito.Venta(factura, total, fecha, idUsuario);
        }


        public void Venta_Detalle (string codigo, decimal cantidad, string factura,  decimal totalArticulo)
        {
            objCarrito.Venta_Detalle(codigo, factura, cantidad, totalArticulo);
        }
        #endregion


    }
}
