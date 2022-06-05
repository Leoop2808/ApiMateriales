using ApiMateriales.Entities.Produccion.Request;
using ApiMateriales.Entities.Produccion.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface IProduccionBO
    {
        ObtenerListaProduccionesResponse ObtenerListaProducciones(ObtenerListaProduccionesRequest request, int id_usuario);
        ActualizarEstadoProduccionResponse ActualizarEstadoProduccion(ActualizarEstadoProduccionRequest request, int id_usuario);
        ObtenerInsumosPorLingoteResponse ObtenerInsumosPorLingote(ObtenerInsumosPorLingoteRequest request, int id_usuario);
        ComprobarStockInsumosResponse ComprobarStockInsumos(ComprobarStockInsumosRequest request, int id_usuario);
        RegistrarProduccionResponse RegistrarProduccion(RegistrarProduccionRequest request, int id_usuario);
        ObtenerHistorialProduccionResponse ObtenerHistorialProduccion(ObtenerHistorialProduccionRequest request, int id_usuario);
    }
}
