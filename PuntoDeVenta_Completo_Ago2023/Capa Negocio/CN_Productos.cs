using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_de_datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Productos
    {
        readonly CD_Productos objProductos = new CD_Productos();
        //readonly CE_Productos objeto_CE_Productos = new CE_Productos();

        #region Buscar
        public DataTable BuscarProducto(string busqueda)
        {
            return objProductos.Buscar(busqueda);
        }
        #endregion

        #region CRUD

        #region Consultar

        public CE_Productos Consulta (int IdArticulo)
        {
            return objProductos.Consulta(IdArticulo);
        }




        #endregion

        #region Insertar

            public void Insertar(CE_Productos productos)
            {
                objProductos.CD_Insertar(productos);
            }


        #endregion

        #region Eliminar

        public void Eliminar(CE_Productos cE_Productos)
        {
            objProductos.CD_Eliminar(cE_Productos);
        }


        #endregion

        #region ActualizarDatos

        public void CD_Actualizar(CE_Productos productos)
        {
            objProductos.CD_Actualizar(productos);
        }



        #endregion


        #region actualizarImg
            
        public void CN_ActualizarIMG(CE_Productos productos)
        {
            objProductos.CD_ActualizarImg(productos);
        }




        #endregion



        #endregion



    }
}
