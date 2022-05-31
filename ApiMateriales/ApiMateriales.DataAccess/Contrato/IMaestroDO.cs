using ApiMateriales.Entities.Maestro.Response;

namespace ApiMateriales.DataAccess.Contrato
{
    public interface IMaestroDO
    {
        ObtenerPaisResponse ObtenerPais(int id_usuario);
        ObtenerProductoResponse ObtenerProducto(int id_usuario);
        ObtenerProductoFinalResponse ObtenerProductoFinal(int id_usuario);
        ObtenerEstadoProduccionResponse ObtenerEstadoProduccion(int id_usuario);
    }
}
