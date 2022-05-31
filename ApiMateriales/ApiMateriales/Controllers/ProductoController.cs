using ApiMateriales.Bussiness.Contrato;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/producto")]
    public class ProductoController : ApiController
    {
        private readonly IProductoBO _productoBO;
        public ProductoController(IProductoBO productoBO)
        {
            _productoBO = productoBO;
        }
    }
}