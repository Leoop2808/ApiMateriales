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
                        codigo = 0,
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
                        descripcion = "No se obtuvo respuesta del servicio de eliminar proveedor"
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

        public ObtenerDetalleProveedorResponse ObtenerDetalleProveedor(int idProveedor, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_DETALLE_PROVEEDOR(idProveedor).FirstOrDefault();
                if (dataRes != null)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_DETALLE_PROVEEDOR_Result, DetalleProveedor>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<SP_OBTENER_DETALLE_PROVEEDOR_Result, DetalleProveedor>(dataRes);

                    return new ObtenerDetalleProveedorResponse()
                    {
                        codigo = 1,
                        descripcion = "Proveedor obtenido correctamente.",
                        datos = datosMapeados
                    };
                }
                else
                {
                    return new ObtenerDetalleProveedorResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos de proveedor."
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerDetalleProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el detalle de proveedor."
                };
            }
        }

        public ObtenerListaClientesResponse ObtenerListaClientes(int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_CLIENTES().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_CLIENTES_Result, DataCliente>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_CLIENTES_Result>, List<DataCliente>>(dataRes);

                    return new ObtenerListaClientesResponse()
                    {
                        codigo = 1,
                        descripcion = "Clientes obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerListaClientesResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos de clientes.",
                        datos = new List<DataCliente>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerListaClientesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de clientes."
                };
            }
        }

        public RegistrarClienteResponse RegistrarCliente(RegistrarClienteRequest request, int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_REGISTRAR_CLIENTE(request.codPais, request.nombreCliente,
                request.ruc, request.direccion, request.celular, request.correo, request.representante,
                request.celularRepre, request.correoRepre).FirstOrDefault();

                if (dataRes != null)
                {
                    return new RegistrarClienteResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new RegistrarClienteResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de registro de cliente"
                    };
                }
            }
            catch (Exception)
            {
                return new RegistrarClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de registrar cliente"
                };
            }
        }

        public EditarClienteResponse EditarCliente(EditarClienteRequest request, int idProveedor, int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_EDITAR_CLIENTE(idProveedor, request.codPais, request.nombreCliente,
                request.ruc, request.direccion, request.celular, request.correo, request.representante,
                request.celularRepre, request.correoRepre).FirstOrDefault();

                if (dataRes != null)
                {
                    return new EditarClienteResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new EditarClienteResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de editar de cliente"
                    };
                }
            }
            catch (Exception)
            {
                return new EditarClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de editar cliente"
                };
            }
        }
        public EliminarClienteResponse EliminarCliente(int idProveedor, int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_ELIMINAR_CLIENTE(idProveedor).FirstOrDefault();

                if (dataRes != null)
                {
                    return new EliminarClienteResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new EliminarClienteResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de eliminar cliente"
                    };
                }
            }
            catch (Exception)
            {
                return new EliminarClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de eliminar cliente"
                };
            }
        }

        public ObtenerDetalleClienteResponse ObtenerDetalleCliente(int idProveedor, int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_DETALLE_CLIENTE(idProveedor).FirstOrDefault();
                if (dataRes != null)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_DETALLE_CLIENTE_Result, DetalleCliente>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<SP_OBTENER_DETALLE_CLIENTE_Result, DetalleCliente>(dataRes);

                    return new ObtenerDetalleClienteResponse()
                    {
                        codigo = 1,
                        descripcion = "Cliente obtenido correctamente.",
                        datos = datosMapeados
                    };
                }
                else
                {
                    return new ObtenerDetalleClienteResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos de cliente."
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerDetalleClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el detalle de cliente."
                };
            }
        }
    }
}
