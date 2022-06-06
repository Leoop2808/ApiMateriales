using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Entities.Inventario.Request;
using ApiMateriales.Entities.Inventario.Response;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/inventario")]
    public class InventarioController : ApiController
    {
        private readonly IInventarioBO _inventarioBO;
        public InventarioController(IInventarioBO inventarioBO)
        {
            _inventarioBO = inventarioBO;
        }

        [Route("flujo/productos-finales")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ObtenerFlujoProductoFinal(ObtenerFlujoProductoFinalRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_inventarioBO.ObtenerFlujoProductoFinal(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerFlujoProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener lista de producciones"
                });
            }
        }

        [Route("flujo/productos")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ObtenerFlujoProducto(ObtenerFlujoProductoRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_inventarioBO.ObtenerFlujoProducto(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerFlujoProductoResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener lista de producciones"
                });
            }
        }

        [Route("stock/productos-finales/actualizar-precio")]
        [HttpPut]
        [Authorize]
        public IHttpActionResult ActualizarPrecioProductoFinal(ActualizarPrecioProductoFinalRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_inventarioBO.ActualizarPrecioProductoFinal(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ActualizarPrecioProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al actualizar precio de producto final"
                });
            }
        }

        [Route("stock/productos-finales")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ObtenerStocksProductosFinales(ObtenerStocksProductosFinalesRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_inventarioBO.ObtenerStocksProductosFinales(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerStocksProductosFinalesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener stocks productos finales"
                });
            }
        }

        [Route("stock/productos")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ObtenerStocksProductos(ObtenerStocksProductosRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_inventarioBO.ObtenerStocksProductos(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerStocksProductosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener stocks productos"
                });
            }
        }
    }
}