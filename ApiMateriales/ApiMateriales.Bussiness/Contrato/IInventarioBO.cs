using ApiMateriales.Entities.Inventario.Request;
using ApiMateriales.Entities.Inventario.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface IInventarioBO
    {
        ObtenerFlujoProductoFinalResponse ObtenerFlujoProductoFinal(ObtenerFlujoProductoFinalRequest request, int id_usuario);
        ObtenerFlujoProductoResponse ObtenerFlujoProducto(ObtenerFlujoProductoRequest request, int id_usuario);
        ActualizarPrecioProductoFinalResponse ActualizarPrecioProductoFinal(ActualizarPrecioProductoFinalRequest request, int id_usuario);
        ObtenerStocksProductosFinalesResponse ObtenerStocksProductosFinales(ObtenerStocksProductosFinalesRequest request, int id_usuario);
        ObtenerStocksProductosResponse ObtenerStocksProductos(ObtenerStocksProductosRequest request, int id_usuario);
    }
}
