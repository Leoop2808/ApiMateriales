using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Models;
using ApiMateriales.Entities.Produccion.Request;
using ApiMateriales.Entities.Produccion.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiMateriales.DataAccess.Implementacion
{
    public class ProduccionDO : IProduccionDO
    {
        public ObtenerListaProduccionesResponse ObtenerListaProducciones(ObtenerListaProduccionesRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_PRODUCCIONES(request.codEstadoProduccion, request.fechaDesde, request.fechaHasta).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_PRODUCCIONES_Result, DatosProduccion>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_PRODUCCIONES_Result>, List<DatosProduccion>>(dataRes);

                    return new ObtenerListaProduccionesResponse()
                    {
                        codigo = 1,
                        descripcion = "Producciones obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerListaProduccionesResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron datos de producción.",
                        datos = new List<DatosProduccion>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerListaProduccionesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el listado de producciones."
                };
            }
        }
        public ActualizarEstadoProduccionResponse ActualizarEstadoProduccion(ActualizarEstadoProduccionRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_ACTUALIZAR_ESTADO_PRODUCCION(request.idProduccion, request.codEstadoProduccion).FirstOrDefault();

                if (dataRes != null)
                {
                    return new ActualizarEstadoProduccionResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new ActualizarEstadoProduccionResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de actualizar estado de producción"
                    };
                }
            }
            catch (Exception)
            {
                return new ActualizarEstadoProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de actualizar estado de producción"
                };
            }
        }
        public ObtenerInsumosPorLingoteResponse ObtenerInsumosPorLingote(ObtenerInsumosPorLingoteRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_INSUMOS_POR_LINGOTE(request.codProductoFinal, request.cantidadProduccion).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_INSUMOS_POR_LINGOTE_Result, DatosInsumo>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_INSUMOS_POR_LINGOTE_Result>, List<DatosInsumo>>(dataRes);

                    return new ObtenerInsumosPorLingoteResponse()
                    {
                        codigo = 1,
                        descripcion = "Insumos necesarios obtenidos correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerInsumosPorLingoteResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvieron los insumos necesarios.",
                        datos = new List<DatosInsumo>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerInsumosPorLingoteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener los insumos necesarios."
                };
            }
        }
        public ComprobarStockInsumosResponse ComprobarStockInsumos(ComprobarStockInsumosRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_PREPRODUCCION_COMPROBAR_STOCK_INSUMOS(request.codProductoFinal, request.cantidadProduccion).FirstOrDefault();
                if (dataRes != null)
                {
                    return new ComprobarStockInsumosResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new ComprobarStockInsumosResponse()
                    {
                        codigo = 0,
                        descripcion = "No se pudo comprobar los insumos necesarios."
                    };
                }
            }
            catch (Exception e)
            {
                return new ComprobarStockInsumosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al comprobar los insumos necesarios."
                };
            }
        }
        public RegistrarProduccionResponse RegistrarProduccion(RegistrarProduccionRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_REGISTRAR_PRODUCCION(request.codProductoFinal, request.cantidad, request.fechaInicio, request.fechaComprometida).FirstOrDefault();

                if (dataRes != null)
                {
                    return new RegistrarProduccionResponse()
                    {
                        codigo = dataRes.codigo.GetValueOrDefault(),
                        descripcion = dataRes.descripcion
                    };
                }
                else
                {
                    return new RegistrarProduccionResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo respuesta del servicio de registro de producción"
                    };
                }
            }
            catch (Exception)
            {
                return new RegistrarProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de registrar producción"
                };
            }
        }
        public ObtenerHistorialProduccionResponse ObtenerHistorialProduccion(ObtenerHistorialProduccionRequest request, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_HISTORIAL_PRODUCCION(request.fechaDesde, request.fechaHasta, request.codProductoFinal).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_HISTORIAL_PRODUCCION_Result, DatosHistorialProduccion>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_HISTORIAL_PRODUCCION_Result>, List<DatosHistorialProduccion>>(dataRes);

                    return new ObtenerHistorialProduccionResponse()
                    {
                        codigo = 1,
                        descripcion = "Historial de producción obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerHistorialProduccionResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo el historial de producción.",
                        datos = new List<DatosHistorialProduccion>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerHistorialProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener historial de producción."
                };
            }
        }
    }
}
