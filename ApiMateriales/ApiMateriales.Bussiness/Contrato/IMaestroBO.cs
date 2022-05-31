using ApiMateriales.Entities.Maestro.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface IMaestroBO
    {
        ObtenerListaMaestrosResponse ObtenerListaMaestros(int id_usuario);
    }
}
