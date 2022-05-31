using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Models;
using ApiMateriales.Entities.Contacto.Request;
using ApiMateriales.Entities.Contacto.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiMateriales.DataAccess.Implementacion
{
    public class ContactoDO : IContactoDO
    {
        public ObtenerListaProveedoresResponse ObtenerListaProveedores(int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PROVEEDORES().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PROVEEDORES_Result, DataProveedor>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PROVEEDORES_Result>, List<DataProveedor>>(dataRes);

                    return new ObtenerListaProveedoresResponse()
                    {
                        codigo = 1,
                        descripcion = "Proveedores obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerListaProveedoresResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de proveedores.",
                        datos = new List<DataProveedor>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerListaProveedoresResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de proveedores."
                };
            }
        }

        public RegistrarProveedorResponse RegistrarProveedor(RegistrarProveedorRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_REGISTRAR_PROVEEDOR(request.codPais, request.nombreProveedor,
                request.ruc, request.direccion, request.celular, request.correo, request.representante,
                request.celularRepre, request.correoRepre).FirstOrDefault();

                if (dataRes != null)
                {
                    return new RegistrarProveedorResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new RegistrarProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de registro de proveedor"
                    };
                }
            }
            catch (Exception)
            {
                return new RegistrarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de registrar proveedor"
                };
            }
        }

        public EditarProveedorResponse EditarProveedor(EditarProveedorRequest request, int idProveedor, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_EDITAR_PROVEEDOR(idProveedor, request.codPais, request.nombreProveedor,
                request.ruc, request.direccion, request.celular, request.correo, request.representante,
                request.celularRepre, request.correoRepre).FirstOrDefault();

                if (dataRes != null)
                {
                    return new EditarProveedorResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new EditarProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de editar de proveedor"
                    };
                }
            }
            catch (Exception)
            {
                return new EditarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de editar proveedor"
                };
            }
        }
        public EliminarProveedorResponse EliminarProveedor(int idProveedor, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_ELIMINAR_PROVEEDOR(idProveedor).FirstOrDefault();

                if (dataRes != null)
                {
                    return new EliminarProveedorResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new EliminarProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de eliminar de proveedor"
                    };
                }
            }
            catch (Exception)
            {
                return new EliminarProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de eliminar proveedor"
                };
            }
        }
    }
}
