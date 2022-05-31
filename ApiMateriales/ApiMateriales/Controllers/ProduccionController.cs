using ApiMateriales.Bussiness.Contrato;
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
    }
}