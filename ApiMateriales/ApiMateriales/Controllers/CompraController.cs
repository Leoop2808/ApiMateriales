using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Entities.Compra.Request;
using ApiMateriales.Entities.Compra.Response;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/compra")]
    public class CompraController : ApiController
    {
        private readonly ICompraBO _compraBO;
        public CompraController(ICompraBO compraBO)
        {
            _compraBO = compraBO;
        }

        [Route("registrar-compra")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult RegistrarCompra(RegistrarCompraRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new RegistrarCompraResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_compraBO.RegistrarCompra(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new RegistrarCompraResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al registrar compra"
                });
            }
        }

        [Route("historial-compras")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ObtenerHistorialCompras(string nombreProveedor)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_compraBO.ObtenerHistorialCompras(nombreProveedor, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerHistorialComprasResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener historial de compras"
                });
            }
        }

        [Route("detalle-compra/{idCompra}")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ObtenerDetalleCompra(int idCompra)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_compraBO.ObtenerDetalleCompra(idCompra, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerHistorialComprasResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener detalle de compra"
                });
            }
        }
    }
}