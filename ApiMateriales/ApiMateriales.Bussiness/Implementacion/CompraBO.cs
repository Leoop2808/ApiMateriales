using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class CompraBO : ICompraBO
    {
        private readonly ICompraDO _compraDO;
        public CompraBO(ICompraDO compraDO)
        {
            _compraDO = compraDO;
        }
    }
}
