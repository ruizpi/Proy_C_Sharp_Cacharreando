using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_de_datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios objDatos = new CD_Usuarios();

        #region Consultar
        public CE_Usuarios Consulta(int IdUsuario)
        {
            return objDatos.Consulta(IdUsuario);

        }
        #endregion

        #region Insertar
        
        public void Insertar(CE_Usuarios Usuarios)
        {
            objDatos.CD_Insertar(Usuarios);
        }



        #endregion

        #region Eliminar

        public void Eliminar(CE_Usuarios Usuarios)
        {
            objDatos.CD_Eliminar(Usuarios);
        }


        #endregion

        #region Actualizar Datos

        public void ActualizarDatos (CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarDatos(Usuarios);
        }


        #endregion

        #region Actualizar Pass

        public void ActualizarPass(CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarPass(Usuarios);
        }


        #endregion

        #region Actualizar IMG

        #region Cargar Usuariois
        public void ActualizarIMG(CE_Usuarios Usuarios)
        {
            objDatos.CD_ActualizarIMG(Usuarios);
        }
        #endregion


        #endregion

        /*
         * LO COMENTAMOS PORQUE YA CON EL METODO BUSCAR USUARIOS ES MAS QUE SUFICIENTE
         * 
        public DataTable CargarUsuarios()
        {
            return objDatos.CargarUsuarios();
        }
        */
        public DataTable BuscarUsuario(string busqueda)
        {
            return objDatos.Buscar(busqueda);
        }

        #region LOGIN
        public CE_Usuarios Login (string usuario, string contrasena)
        {
            return objDatos.Login(usuario, contrasena);
        }
        #endregion

        #region Carga MiCuenta 
        public CE_Usuarios Cargar(int idUsuario)
        {
            return objDatos.Consulta(idUsuario);
        }
        #endregion


    }
}
