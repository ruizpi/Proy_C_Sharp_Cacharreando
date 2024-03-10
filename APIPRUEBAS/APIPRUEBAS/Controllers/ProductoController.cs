using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using APIPRUEBAS.Model;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

// ESTO ES NECESARIO PARA QUE PUEDAN EJECUTARLE LAS CORS O POLITICAS DE USO
using Microsoft.AspNetCore.Cors;




namespace APIPRUEBAS.Controllers
{
    // ESTO DEFINITIVAMENTE HACE QUE SE APLIQUEN LAS CORS A ESTE CONTROLADOR
    [EnableCors("ReglasCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        public readonly DbapiContext _dbcontext;

        public ProductoController (DbapiContext _context)
        {
            _dbcontext = _context;

        }

        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Producto> lista = new List<Producto>(); 
            
            try {

                // PRIMERA VEZ SE PONE ESTO PARA SACAR LA LISTA DE PRODUCTOS
                // SE COMENTA PORQUE LA FOREIGN KEY SALE A NULL CUANDO SE LE PONE ESTO
                // EN LA SIGUIENTE LINEA DE CODIGO SIN COMENTAR SE VA CONSEGUIR PONER
                // LA CATEGORIA 
                //lista = _dbcontext.Productos.ToList();

                // AQUI SE VA A PODER INCLUIR LA CATEGORIA AL SACAR EL JSON
                lista = _dbcontext.Productos.Include(c => c.oCategoria).ToList();   

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = lista });
            
            }catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }

        [HttpGet]
        [Route("Obtener/{idProducto:int}")]
        public IActionResult Obtener(int idProducto)
        {
            Producto oProducto = _dbcontext.Productos.Find(idProducto);

            if (oProducto == null)
            {
                return BadRequest("Producto no encontrado");
            }



            try
            {

                oProducto = _dbcontext.Productos.Include(c =>c.oCategoria).ToList().Where(p => p.IdProducto == idProducto).FirstOrDefault();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = oProducto });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = oProducto });
            }
        }

        [HttpPost]
        [Route("Guardar/")]
        public IActionResult Guardar([FromBody] Producto objeto)
        {

            try { 
            
                _dbcontext.Productos.Add(objeto);
                _dbcontext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });


            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = objeto });
            }

        }

        [HttpPut]
        [Route("Editar/")]
        public IActionResult Editar([FromBody] Producto objeto)
        {

            Producto oProducto = _dbcontext.Productos.Find(objeto.IdProducto);

            if (oProducto == null)
            {
                return BadRequest("Producto no encontrado");
            }


            try
            {
                oProducto.CodigoBarra = objeto.CodigoBarra is null ? oProducto.CodigoBarra : objeto.CodigoBarra;
                oProducto.Descripcion = objeto.Descripcion is null ? oProducto.Descripcion : objeto.Descripcion;
                oProducto.Marca = objeto.Marca is null ? oProducto.Marca : objeto.Marca;
                oProducto.IdCategoria = objeto.IdCategoria is null ? oProducto.IdCategoria : objeto.IdCategoria;
                oProducto.Precio = objeto.Precio is null ? oProducto.Precio :   objeto.Precio;



                _dbcontext.Productos.Update(oProducto);
                _dbcontext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = objeto });
            }

        }

        [HttpDelete]
        [Route("Eliminar/{idProducto:int}")]
        public IActionResult Eliminar(int idProducto)
        {

            Producto oProducto = _dbcontext.Productos.Find(idProducto);

            if (oProducto == null)
            {
                return BadRequest("Producto no encontrado");
            }


            try
            {

                _dbcontext.Productos.Remove(oProducto); 

                _dbcontext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = oProducto });
            }

        }


    }
}
