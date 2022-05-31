using ApiMateriales.Bussiness.Contrato;
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
    }
}