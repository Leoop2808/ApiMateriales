using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class ProduccionBO : IProduccionBO
    {
        private readonly IProduccionDO _produccionDO;
        public ProduccionBO(IProduccionDO produccionDO)
        {
            _produccionDO = produccionDO;
        }
    }
}
