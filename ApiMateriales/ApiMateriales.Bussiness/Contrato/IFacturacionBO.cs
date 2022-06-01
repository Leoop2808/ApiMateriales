using ApiMateriales.Entities.Facturacion.Request;
using ApiMateriales.Entities.Facturacion.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface IFacturacionBO
    {
        RegistrarVentaResponse RegistrarVenta(RegistrarVentaRequest request, int id_usuario);
    }
}
