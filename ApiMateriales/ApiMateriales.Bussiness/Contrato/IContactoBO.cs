using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;

namespace ApiMateriales.Bussiness.Contrato
{
    public interface IContactoBO
    {
        ObtenerListaProveedoresResponse ObtenerListaProveedores(int id_usuario);
        RegistrarProveedorResponse RegistrarProveedor(RegistrarProveedorRequest request, int id_usuario);
    }
}
