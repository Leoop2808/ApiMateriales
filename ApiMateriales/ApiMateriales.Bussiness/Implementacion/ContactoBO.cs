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
        public ObtenerListaProveedoresResponse ObtenerListaProveedores(int id_usuario) 
        {
            try
            {
                return _contactoDO.ObtenerListaProveedores(id_usuario);
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
    }
}
