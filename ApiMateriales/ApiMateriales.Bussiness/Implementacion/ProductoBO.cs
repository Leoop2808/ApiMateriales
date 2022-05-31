using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class ProductoBO : IProductoBO
    {
        private readonly IProductoDO _productoDO;
        public ProductoBO(IProductoDO productoDO)
        {
            _productoDO = productoDO;
        }
    }
}
