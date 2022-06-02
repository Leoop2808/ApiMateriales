using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;

namespace ApiMateriales.DataAccess.Contrato
{
    public interface IContactoDO
    {
        ObtenerListaProveedoresResponse ObtenerListaProveedores(string nombreProveedor, int id_usuario);
        RegistrarProveedorResponse RegistrarProveedor(RegistrarProveedorRequest request, int id_usuario);
        EditarProveedorResponse EditarProveedor(EditarProveedorRequest request, int idProveedor, int id_usuario);
        EliminarProveedorResponse EliminarProveedor(int idProveedor, int id_usuario);
        ObtenerDetalleProveedorResponse ObtenerDetalleProveedor(int idProveedor, int id_usuario);
        ObtenerListaClientesResponse ObtenerListaClientes(string nombreCliente, int id_usuario);
        RegistrarClienteResponse RegistrarCliente(RegistrarClienteRequest request, int id_usuario);
        EditarClienteResponse EditarCliente(EditarClienteRequest request, int idCliente, int id_usuario);
        EliminarClienteResponse EliminarCliente(int idCliente, int id_usuario);
        ObtenerDetalleClienteResponse ObtenerDetalleCliente(int idCliente, int id_usuario);
    }
}
