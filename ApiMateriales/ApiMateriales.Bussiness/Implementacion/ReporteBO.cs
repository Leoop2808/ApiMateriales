using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class ReporteBO : IReporteBO
    {
        private readonly IReporteDO _reporteDO;
        public ReporteBO(IReporteDO reporteDO)
        {
            _reporteDO = reporteDO;
        }
    }
}
