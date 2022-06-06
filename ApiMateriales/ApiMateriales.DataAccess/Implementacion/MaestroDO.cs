using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Models;
using ApiMateriales.Entities.Maestro.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiMateriales.DataAccess.Implementacion
{
    public class MaestroDO : IMaestroDO
    {
        public ObtenerPaisResponse ObtenerPais(int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PAIS().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PAIS_Result, DataPais>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PAIS_Result>, List<DataPais>>(dataRes);

                    return new ObtenerPaisResponse()
                    {
                        codigo = 1,
                        descripcion = "Paises obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerPaisResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de paises.",
                        datos = new List<DataPais>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerPaisResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de paises."
                };
            }
        }
        public ObtenerProductoResponse ObtenerProducto(int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PRODUCTO().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PRODUCTO_Result, DataProducto>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PRODUCTO_Result>, List<DataProducto>>(dataRes);

                    return new ObtenerProductoResponse()
                    {
                        codigo = 1,
                        descripcion = "Productos obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerProductoResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de productos.",
                        datos = new List<DataProducto>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerProductoResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de productos."
                };
            }
        }
        public ObtenerProductoFinalResponse ObtenerProductoFinal(int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PRODUCTO_FINAL().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PRODUCTO_FINAL_Result, DataProductoFinal>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PRODUCTO_FINAL_Result>, List<DataProductoFinal>>(dataRes);

                    return new ObtenerProductoFinalResponse()
                    {
                        codigo = 1,
                        descripcion = "Productos finales obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerProductoFinalResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de productos finales.",
                        datos = new List<DataProductoFinal>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de productos finales."
                };
            }
        }
        public ObtenerEstadoProduccionResponse ObtenerEstadoProduccion(int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_ESTADOS_PRODUCCION().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_ESTADOS_PRODUCCION_Result, DataEstadoProduccion>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_ESTADOS_PRODUCCION_Result>, List<DataEstadoProduccion>>(dataRes);

                    return new ObtenerEstadoProduccionResponse()
                    {
                        codigo = 1,
                        descripcion = "Estados de producción obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerEstadoProduccionResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de estados de producción.",
                        datos = new List<DataEstadoProduccion>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerEstadoProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de estados de producción."
                };
            }
        }

        public ObtenerClienteResponse ObtenerCliente(int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_MAESTRO_CLIENTE().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_MAESTRO_CLIENTE_Result, DataCliente>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_MAESTRO_CLIENTE_Result>, List<DataCliente>>(dataRes);

                    return new ObtenerClienteResponse()
                    {
                        codigo = 1,
                        descripcion = "Clientes obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerClienteResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de clientes.",
                        datos = new List<DataCliente>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerClienteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de clientes."
                };
            }
        }
        public ObtenerProveedorResponse ObtenerProveedor(int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_MAESTRO_PROVEEDOR().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_MAESTRO_PROVEEDOR_Result, DataProveedor>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_MAESTRO_PROVEEDOR_Result>, List<DataProveedor>>(dataRes);

                    return new ObtenerProveedorResponse()
                    {
                        codigo = 1,
                        descripcion = "Proveedores obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerProveedorResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de proveedores.",
                        datos = new List<DataProveedor>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerProveedorResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de proveedores."
                };
            }
        }
        public ObtenerProductosFinalesMasVendidosResponse ObtenerProductosFinalesMasVendidos(int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS_Result, DatosProductoFinalMasVendido>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PRODUCTOS_FINALES_MAS_VENDIDOS_Result>, List<DatosProductoFinalMasVendido>>(dataRes);

                    return new ObtenerProductosFinalesMasVendidosResponse()
                    {
                        codigo = 1,
                        descripcion = "Productos finales mas vendidos obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerProductosFinalesMasVendidosResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de los productos finales mas vendidos.",
                        datos = new List<DatosProductoFinalMasVendido>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerProductosFinalesMasVendidosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de productos finales mas vendidos."
                };
            }
        }
        public ObtenerProductosMasCompradosResponse ObtenerProductosMasComprados(int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PRODUCTOS_MAS_COMPRADOS().ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PRODUCTOS_MAS_COMPRADOS_Result, DatosProductoMasComprado>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PRODUCTOS_MAS_COMPRADOS_Result>, List<DatosProductoMasComprado>>(dataRes);

                    return new ObtenerProductosMasCompradosResponse()
                    {
                        codigo = 1,
                        descripcion = "Productos mas comprados obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerProductosMasCompradosResponse()
                    {
                        codigo = 1,
                        descripcion = "No se obtuvieron datos de productos mas comprados.",
                        datos = new List<DatosProductoMasComprado>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerProductosMasCompradosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de productos mas comprados."
                };
            }
        }
    }
}
