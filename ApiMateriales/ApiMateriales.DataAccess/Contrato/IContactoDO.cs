using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;

namespace ApiMateriales.DataAccess.Contrato
{
    public interface IContactoDO
    {
        ObtenerListaProveedoresResponse ObtenerListaProveedores(int id_usuario);
        RegistrarProveedorResponse RegistrarProveedor(RegistrarProveedorRequest request, int id_usuario);
        EditarProveedorResponse EditarProveedor(EditarProveedorRequest request, int idProveedor, int id_usuario);
        EliminarProveedorResponse EliminarProveedor(int idProveedor, int id_usuario);
    }
}
