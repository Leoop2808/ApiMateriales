using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Models;
using ApiMateriales.Entities.Inventario.Request;
using ApiMateriales.Entities.Inventario.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiMateriales.DataAccess.Implementacion
{
    public class InventarioDO : IInventarioDO
    {
        public ObtenerFlujoProductoFinalResponse ObtenerFlujoProductoFinal(ObtenerFlujoProductoFinalRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_FLUJO_PRODUCTO_FINAL(request.codProductoFinal, request.fechaDesde, request.fechaHasta).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_FLUJO_PRODUCTO_FINAL_Result, DatosFlujoProductoFinal>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_FLUJO_PRODUCTO_FINAL_Result>, List<DatosFlujoProductoFinal>>(dataRes);

                    return new ObtenerFlujoProductoFinalResponse()
                    {
                        codigo = 1,
                        descripcion = "Flujo de producto final obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerFlujoProductoFinalResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos del flujo de producto final.",
                        datos = new List<DatosFlujoProductoFinal>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerFlujoProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el flujo de producto final."
                };
            }
        }
        public ObtenerFlujoProductoResponse ObtenerFlujoProducto(ObtenerFlujoProductoRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_FLUJO_PRODUCTO(request.codProducto, request.fechaDesde, request.fechaHasta).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_FLUJO_PRODUCTO_Result, DatosFlujoProducto>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_FLUJO_PRODUCTO_Result>, List<DatosFlujoProducto>>(dataRes);

                    return new ObtenerFlujoProductoResponse()
                    {
                        codigo = 1,
                        descripcion = "Flujo de producto obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerFlujoProductoResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos del flujo de producto.",
                        datos = new List<DatosFlujoProducto>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerFlujoProductoResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el flujo de producto."
                };
            }
        }
        public ActualizarPrecioProductoFinalResponse ActualizarPrecioProductoFinal(ActualizarPrecioProductoFinalRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_ACTUALIZAR_PRECIO_PRODUCTO_FINAL(request.idProductoFinal, Convert.ToDecimal(request.precio)).FirstOrDefault();

                if (dataRes != null)
                {
                    return new ActualizarPrecioProductoFinalResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new ActualizarPrecioProductoFinalResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de actualizar precio del producto final"
                    };
                }
            }
            catch (Exception)
            {
                return new ActualizarPrecioProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de actualizar precio del producto final"
                };
            }
        }
        public ObtenerStocksProductosFinalesResponse ObtenerStocksProductosFinales(ObtenerStocksProductosFinalesRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_STOCKS_PRODUCTOS_FINALES(request.codProductoFinal).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_STOCKS_PRODUCTOS_FINALES_Result, DatosStockProductoFinal>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_STOCKS_PRODUCTOS_FINALES_Result>, List<DatosStockProductoFinal>>(dataRes);

                    return new ObtenerStocksProductosFinalesResponse()
                    {
                        codigo = 1,
                        descripcion = "Stocks de productos finales obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerStocksProductosFinalesResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos de stocks de productos finales.",
                        datos = new List<DatosStockProductoFinal>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerStocksProductosFinalesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener stocks de productos finales."
                };
            }
        }
        public ObtenerStocksProductosResponse ObtenerStocksProductos(ObtenerStocksProductosRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_STOCKS_PRODUCTOS(request.codProducto).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_STOCKS_PRODUCTOS_Result, DatosStockProducto>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_STOCKS_PRODUCTOS_Result>, List<DatosStockProducto>>(dataRes);

                    return new ObtenerStocksProductosResponse()
                    {
                        codigo = 1,
                        descripcion = "Stocks de productos obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerStocksProductosResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos de stocks de productos finales.",
                        datos = new List<DatosStockProducto>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerStocksProductosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en al obtener stocks de productos finales."
                };
            }
        }
    }
}
