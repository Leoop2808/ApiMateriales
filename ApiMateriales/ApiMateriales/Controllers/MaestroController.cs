using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Entities.Maestro.Response;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/maestro")]
    public class MaestroController : ApiController
    {
        private readonly IMaestroBO _maestroBO;
        public MaestroController(IMaestroBO maestroBO)
        {
            _maestroBO = maestroBO;
        }

        [Route("lista-maestros")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ObtenerListaMaestros()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new ObtenerListaMaestrosResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_maestroBO.ObtenerListaMaestros(id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerListaMaestrosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno maestros"
                });
            }            
        }
    }
}