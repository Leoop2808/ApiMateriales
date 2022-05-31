using ApiMateriales.Bussiness.Contrato;
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
    }
}