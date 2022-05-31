using ApiMateriales.Bussiness.Contrato;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/reporte")]
    public class ReporteController : ApiController
    {
        private readonly IReporteBO _reporteBO;
        public ReporteController(IReporteBO reporteBO)
        {
            _reporteBO = reporteBO;
        }
    }
}
