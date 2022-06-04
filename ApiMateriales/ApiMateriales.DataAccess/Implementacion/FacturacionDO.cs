using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Models;
using ApiMateriales.Entities.Facturacion.Request;
using ApiMateriales.Entities.Facturacion.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ApiMateriales.DataAccess.Implementacion
{
    public class FacturacionDO : IFacturacionDO
    {
        public RegistrarVentaResponse RegistrarVenta(DataTable dtVentaProductoFinal, string codCliente, double igv, double importeTotal, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();

                var parameterCodCliente = new SqlParameter
                {
                    SqlDbType = SqlDbType.VarChar,
                    ParameterName = "@codCliente",
                    Value = codCliente
                };

                var parameterTblVentaProductoFinal = new SqlParameter
                {
                    SqlDbType = SqlDbType.Structured,
                    ParameterName = "@tblVentaProductoFinal",
                    Value = dtVentaProductoFinal,
                    TypeName = "Type_VentaProductoFinal"
                };

                var parameterIgv = new SqlParameter
                {
                    SqlDbType = SqlDbType.Decimal,
                    ParameterName = "@igv",
                    Value = Convert.ToDecimal(igv)
                };

                var parameterImporteTotal = new SqlParameter
                {
                    SqlDbType = SqlDbType.Decimal,
                    ParameterName = "@importeTotal",
                    Value = Convert.ToDecimal(importeTotal)
                };                              

                ctx.Database.CommandTimeout = 3000;
                var response = ctx.Database.SqlQuery<RegistrarVentaResponse>(
                    "SP_REGISTRAR_VENTA " +
                    "@codCliente, @tblVentaProductoFinal, @igv, @importeTotal",
                    parameterCodCliente, parameterTblVentaProductoFinal, parameterIgv, parameterImporteTotal
                    ).FirstOrDefault();

                if (response == null)
                {
                    return new RegistrarVentaResponse()
                    {
                        codigo = 0,
                        descripcion = "No se logro regisrtar los datos de la venta."
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                return new RegistrarVentaResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de registrar venta"
                };
            }
        }
        public ObtenerHistorialVentasResponse ObtenerHistorialVentas(string nombreCliente, int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_HISTORIAL_VENTAS(nombreCliente).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_HISTORIAL_VENTAS_Result, DatosHistorialVenta>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_HISTORIAL_VENTAS_Result>, List<DatosHistorialVenta>>(dataRes);

                    return new ObtenerHistorialVentasResponse()
                    {
                        codigo = 1,
                        descripcion = "Historial de ventas obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerHistorialVentasResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo el historial de ventas.",
                        datos = new List<DatosHistorialVenta>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerHistorialVentasResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el historial de ventas."
                };
            }
        }
        public ObtenerDetalleVentaResponseOk ObtenerDetalleVenta(int idVenta, int id_usuario)
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_DETALLE_VENTA(idVenta).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_DETALLE_VENTA_Result, DetalleVentaResponseOk>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_DETALLE_VENTA_Result>, List<DetalleVentaResponseOk>>(dataRes);

                    return new ObtenerDetalleVentaResponseOk()
                    {
                        codigo = 1,
                        descripcion = "Detalle de venta obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerDetalleVentaResponseOk()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo el detalle de venta.",
                        datos = new List<DetalleVentaResponseOk>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerDetalleVentaResponseOk()
                {
                    codigo = -1,
                    descripcion = "Error interno en el detalle de venta."
                };
            }
        }
    }
}
