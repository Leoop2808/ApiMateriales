using ApiMateriales.Entities.Maestro.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface IMaestroBO
    {
        ObtenerListaMaestrosResponse ObtenerListaMaestros(int id_usuario);
        ObtenerProductosFinalesMasVendidosResponse ObtenerProductosFinalesMasVendidos(int id_usuario);
        ObtenerProductosMasCompradosResponse ObtenerProductosMasComprados(int id_usuario);
    }
}
