using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Entities.Facturacion.Request;
using ApiMateriales.Entities.Facturacion.Response;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/facturacion")]
    public class FacturacionController : ApiController
    {
        private readonly IFacturacionBO _facturacionBO;
        public FacturacionController(IFacturacionBO facturacionBO)
        {
            _facturacionBO = facturacionBO;
        }

        [Route("registrar-venta")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult RegistrarVenta(RegistrarVentaRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new RegistrarVentaResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_facturacionBO.RegistrarVenta(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new RegistrarVentaResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al registrar venta"
                });
            }
        }
    }
}