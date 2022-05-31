using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;

namespace ApiMateriales.DataAccess.Contrato
{
    public interface IContactoDO
    {
        ObtenerListaProveedoresResponse ObtenerListaProveedores(int id_usuario);
        RegistrarProveedorResponse RegistrarProveedor(RegistrarProveedorRequest request, int id_usuario);
    }
}
