using ApiMateriales.Entities.Compra.Request;
using ApiMateriales.Entities.Compra.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface ICompraBO
    {
        RegistrarCompraResponse RegistrarCompra(RegistrarCompraRequest request, int id_usuario);
        ObtenerHistorialComprasResponse ObtenerHistorialCompras(string nombreProveedor, int id_usuario);
        ObtenerDetalleCompraResponse ObtenerDetalleCompra(int idCompra, int id_usuario);
    }
}
