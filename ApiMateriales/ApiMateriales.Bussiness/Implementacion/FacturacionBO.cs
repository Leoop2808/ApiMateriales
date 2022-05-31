using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class FacturacionBO : IFacturacionBO
    {
        private readonly IFacturacionDO _facturacionDO;
        public FacturacionBO(IFacturacionDO facturacionDO)
        {
            _facturacionDO = facturacionDO;
        }
    }
}
