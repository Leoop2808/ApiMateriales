using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;
using System;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class ContactoBO : IContactoBO
    {
        private readonly IContactoDO _contactoDO;
        public ContactoBO(IContactoDO contactoDO)
        {
            _contactoDO = contactoDO;
        }
        public ObtenerListaProveedoresResponse ObtenerListaProveedores(string nombreProveedor, int id_usuario) 
        {
            try
            {
                return _contactoDO.ObtenerListaProveedores(nombreProveedor, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerListaProveedoresResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de listar proveedores."
                };
            }
        }

        public RegistrarProveedorResponse RegistrarProveedor(RegistrarProveedorRequest request, int id_usuario) 
        {
            try
            {
                return _contactoDO.RegistrarProveedor(request, id_usuario);
            }
            catch (Exception e)
            {
                return new RegistrarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el registro de proveedor."
                };
            }
        }

        public EditarProveedorResponse EditarProveedor(EditarProveedorRequest request, int idProveedor, int id_usuario) 
        {
            try
            {
                return _contactoDO.EditarProveedor(request, idProveedor, id_usuario);
            }
            catch (Exception e)
            {
                return new EditarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en la edición de proveedor."
                };
            }
        }
        public EliminarProveedorResponse EliminarProveedor(int idProveedor, int id_usuario) 
        {
            try
            {
                return _contactoDO.EliminarProveedor(idProveedor, id_usuario);
            }
            catch (Exception e)
            {
                return new EliminarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en la eliminación de proveedor."
                };
            }
        }
        public ObtenerDetalleProveedorResponse ObtenerDetalleProveedor(int idProveedor, int id_usuario) 
        {
            try
            {
                return _contactoDO.ObtenerDetalleProveedor(idProveedor, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerDetalleProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener detalle de proveedor."
                };
            }
        }
        public ObtenerListaClientesResponse ObtenerListaClientes(string nombreCliente, int id_usuario) 
        {
            try
            {
                return _contactoDO.ObtenerListaClientes(nombreCliente, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerListaClientesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener lista de clientes."
                };
            }
        }
        public RegistrarClienteResponse RegistrarCliente(RegistrarClienteRequest request, int id_usuario)
        {
            try
            {
                return _contactoDO.RegistrarCliente(request, id_usuario);
            }
            catch (Exception e)
            {
                return new RegistrarClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al registrar cliente."
                };
            }
        }
        public EditarClienteResponse EditarCliente(EditarClienteRequest request, int idCliente, int id_usuario)
        {
            try
            {
                return _contactoDO.EditarCliente(request, idCliente, id_usuario);
            }
            catch (Exception e)
            {
                return new EditarClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al editar cliente."
                };
            }
        }
        public EliminarClienteResponse EliminarCliente(int idCliente, int id_usuario)
        {
            try
            {
                return _contactoDO.EliminarCliente(idCliente, id_usuario);
            }
            catch (Exception e)
            {
                return new EliminarClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al eliminar cliente."
                };
            }
        }
        public ObtenerDetalleClienteResponse ObtenerDetalleCliente(int idCliente, int id_usuario)
        {
            try
            {
                return _contactoDO.ObtenerDetalleCliente(idCliente, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerDetalleClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener detalle de cliente."
                };
            }
        }
    }
}
