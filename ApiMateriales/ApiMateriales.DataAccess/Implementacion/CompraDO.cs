using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Models;
using ApiMateriales.Entities.Compra.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ApiMateriales.DataAccess.Implementacion
{
    public class CompraDO : ICompraDO
    {
        public RegistrarCompraResponse RegistrarCompra(DataTable dtCompraProducto, string codProveedor, double importeTotal, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();

                var parameterCodProveedor = new SqlParameter
                {
                    SqlDbType = SqlDbType.VarChar,
                    ParameterName = "@codProveedor",
                    Value = codProveedor
                };

                var parameterTblCompraProducto = new SqlParameter
                {
                    SqlDbType = SqlDbType.Structured,
                    ParameterName = "@tblCompraProducto",
                    Value = dtCompraProducto,
                    TypeName = "Type_CompraProducto"
                };

                var parameterImporteTotal = new SqlParameter
                {
                    SqlDbType = SqlDbType.Decimal,
                    ParameterName = "@importeTotal",
                    Value = Convert.ToDecimal(importeTotal)
                };

                ctx.Database.CommandTimeout = 3000;
                var response = ctx.Database.SqlQuery<RegistrarCompraResponse>(
                    "SP_REGISTRAR_COMPRA " +
                    "@codProveedor, @tblCompraProducto, @importeTotal",
                    parameterCodProveedor, parameterTblCompraProducto, parameterImporteTotal
                    ).FirstOrDefault();

                if (response == null)
                {
                    return new RegistrarCompraResponse()
                    {
                        codigo = 0,
                        descripcion = "No se logro regisrtar los datos de la compra."
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                return new RegistrarCompraResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de registrar compra"
                };
            }
        }
        public ObtenerHistorialComprasResponse ObtenerHistorialCompras(string nombreProveedor, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_HISTORIAL_COMPRAS(nombreProveedor).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_HISTORIAL_COMPRAS_Result, DatosHistorialCompra>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_HISTORIAL_COMPRAS_Result>, List<DatosHistorialCompra>>(dataRes);

                    return new ObtenerHistorialComprasResponse()
                    {
                        codigo = 1,
                        descripcion = "Historial de compras obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerHistorialComprasResponse()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo el historial de compras.",
                        datos = new List<DatosHistorialCompra>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerHistorialComprasResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el historial de compras."
                };
            }
        }
        public ObtenerDetalleCompraResponseOk ObtenerDetalleCompra(int idCompra, int id_usuario) 
        {
            try
            {
                var ctx = new MATERIALESDBEntities();
                var dataRes = ctx.SP_OBTENER_DETALLE_COMPRA(idCompra).ToList();
                if (dataRes != null && dataRes.Count > 0)
                {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<SP_OBTENER_DETALLE_COMPRA_Result, DetalleCompraResponseOk>();
                    });

                    IMapper mapper = config.CreateMapper();
                    var datosMapeados = mapper.Map<List<SP_OBTENER_DETALLE_COMPRA_Result>, List<DetalleCompraResponseOk>>(dataRes);

                    return new ObtenerDetalleCompraResponseOk()
                    {
                        codigo = 1,
                        descripcion = "Detalle de compra obtenido correctamente.",
                        datos = datosMapeados.ToList()
                    };
                }
                else
                {
                    return new ObtenerDetalleCompraResponseOk()
                    {
                        codigo = 0,
                        descripcion = "No se obtuvo el detalle de compra.",
                        datos = new List<DetalleCompraResponseOk>()
                    };
                }
            }
            catch (Exception e)
            {
                return new ObtenerDetalleCompraResponseOk()
                {
                    codigo = -1,
                    descripcion = "Error interno en el detalle de compra."
                };
            }
        }
    }
}
