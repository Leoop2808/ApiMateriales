using ApiMateriales.Entities.Facturacion.Response;
using System.Data;

namespace ApiMateriales.DataAccess.Contrato
{
    public interface IFacturacionDO
    {
        RegistrarVentaResponse RegistrarVenta(DataTable dtVentaProductoFinal, string codCliente, double igv, double importeTotal, int id_usuario);
        ObtenerHistorialVentasResponse ObtenerHistorialVentas(string nombreCliente, int id_usuario);
        ObtenerDetalleVentaResponseOk ObtenerDetalleVenta(int idVenta, int id_usuario);
    }
}
