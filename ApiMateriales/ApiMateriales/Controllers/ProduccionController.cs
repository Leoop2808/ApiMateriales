using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Entities.Produccion.Request;
using ApiMateriales.Entities.Produccion.Response;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/produccion")]
    public class ProduccionController : ApiController
    {
        private readonly IProduccionBO _produccionBO;
        public ProduccionController(IProduccionBO produccionBO)
        {
            _produccionBO = produccionBO;
        }

        [Route("lista-producciones")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult ObtenerListaProducciones(ObtenerListaProduccionesRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_produccionBO.ObtenerListaProducciones(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerListaProduccionesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener lista de producciones"
                });
            }
        }

        [Route("actualizar-estado")]
        [HttpPut]
        [Authorize]
        public IHttpActionResult ActualizarEstadoProduccion(ActualizarEstadoProduccionRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new ActualizarEstadoProduccionResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_produccionBO.ActualizarEstadoProduccion(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ActualizarEstadoProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al actualizar estado de producción"
                });
            }
        }

        [Route("insumos-lingote")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ObtenerInsumosPorLingote(ObtenerInsumosPorLingoteRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new ObtenerInsumosPorLingoteResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_produccionBO.ObtenerInsumosPorLingote(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerInsumosPorLingoteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al registrar producción"
                });
            }
        }

        [Route("comprobar-stock-insumos")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ComprobarStockInsumos(ComprobarStockInsumosRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new ComprobarStockInsumosResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_produccionBO.ComprobarStockInsumos(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ComprobarStockInsumosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al comprobar stock insumos"
                });
            }
        }

        [Route("registrar-produccion")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult RegistrarProduccion(RegistrarProduccionRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errores = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    return Ok(new RegistrarProduccionResponse()
                    {
                        codigo = 0,
                        descripcion = String.Join("||", errores)
                    });
                }
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_produccionBO.RegistrarProduccion(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new RegistrarProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al registrar producción"
                });
            }
        }

        [Route("historial-produccion")]
        [HttpPost]
        [Authorize]
        public IHttpActionResult ObtenerHistorialProduccion(ObtenerHistorialProduccionRequest request)
        {
            try
            {
                int id_usuario = Convert.ToInt32(User.Identity.GetUserId());
                return Ok(_produccionBO.ObtenerHistorialProduccion(request, id_usuario));
            }
            catch (Exception ex)
            {
                return Ok(new ObtenerHistorialProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener historial de producción"
                });
            }
        }


    }
}