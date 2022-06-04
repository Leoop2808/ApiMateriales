using ApiMateriales.Entities.Compra.Response;
using System.Data;

namespace ApiMateriales.DataAccess.Contrato
{
    public interface ICompraDO
    {
        RegistrarCompraResponse RegistrarCompra(DataTable dtCompraProducto, string codProveedor, double importeTotal, int id_usuario);
        ObtenerHistorialComprasResponse ObtenerHistorialCompras(string nombreProveedor, int id_usuario);
        ObtenerDetalleCompraResponseOk ObtenerDetalleCompra(int idCompra, int id_usuario);
    }
}
