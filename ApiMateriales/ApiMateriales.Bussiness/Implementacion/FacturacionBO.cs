using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Facturacion.Request;
using ApiMateriales.Entities.Facturacion.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class FacturacionBO : IFacturacionBO
    {
        private readonly IFacturacionDO _facturacionDO;
        public FacturacionBO(IFacturacionDO facturacionDO)
        {
            _facturacionDO = facturacionDO;
        }
        public RegistrarVentaResponse RegistrarVenta(RegistrarVentaRequest request, int id_usuario)
        {
            try
            {
                DataTable dtVentaProductoFinal = CrearDataTableVentaProductoFinal();
                LlenarDataTableVentaProductoFinal(dtVentaProductoFinal, request.listaProductosFinales);
                return _facturacionDO.RegistrarVenta(dtVentaProductoFinal, request.codCliente, request.igv, request.importeTotal, id_usuario);
            }
            catch (Exception e)
            {
                return new RegistrarVentaResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el registro de venta."
                };
            }
        }

        public DataTable CrearDataTableVentaProductoFinal()
        {
            DataTable dtVentaProductoFinal = new DataTable() { Locale = CultureInfo.InvariantCulture };
            dtVentaProductoFinal.Columns.Add("codProductoFinal", typeof(string));
            dtVentaProductoFinal.Columns.Add("cantidad", typeof(int));
            dtVentaProductoFinal.Columns.Add("subtotal", typeof(double));
            dtVentaProductoFinal.Columns.Add("numRegistroVentaProductoFinal", typeof(int));

            return dtVentaProductoFinal;
        }
        public void LlenarDataTableVentaProductoFinal(DataTable dtVentaProductoFinal, List<DatosProductoFinal> listaProductosFinales)
        {
            int index = 0;
            foreach (var itemProductoFinal in listaProductosFinales)
            {
                dtVentaProductoFinal.Rows.Add();
                dtVentaProductoFinal.Rows[index]["codProductoFinal"] = itemProductoFinal.codProductoFinal;
                dtVentaProductoFinal.Rows[index]["cantidad"] = itemProductoFinal.cantidad;
                dtVentaProductoFinal.Rows[index]["subtotal"] = itemProductoFinal.subtotal;
                dtVentaProductoFinal.Rows[index]["numRegistroVentaProductoFinal"] = index + 1;

                index++;
            }
        }
        public ObtenerHistorialVentasResponse ObtenerHistorialVentas(string nombreCliente, int id_usuario) 
        {
            try
            {
                return _facturacionDO.ObtenerHistorialVentas(nombreCliente, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerHistorialVentasResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener historial de ventas."
                };
            }
        }
        public ObtenerDetalleVentaResponse ObtenerDetalleVenta(int idVenta, int id_usuario) 
        {
            try
            {
                var resDetCompra = _facturacionDO.ObtenerDetalleVenta(idVenta, id_usuario);
                if (resDetCompra.codigo != 1)
                {
                    return new ObtenerDetalleVentaResponse()
                    {
                        codigo = resDetCompra.codigo,
                        descripcion = resDetCompra.descripcion
                    };
                }

                var response = new ObtenerDetalleVentaResponse();
                response.codigo = 1;
                response.descripcion = "Detalle venta obtenido correctamente";
                response.datos = new DetalleVenta();
                response.datos.idVenta = resDetCompra.datos[0].idVenta;
                response.datos.codVenta = resDetCompra.datos[0].codVenta;
                response.datos.fechaVenta = resDetCompra.datos[0].fechaVenta;
                response.datos.nombreCliente = resDetCompra.datos[0].nombreCliente;
                response.datos.ruc = resDetCompra.datos[0].ruc;
                response.datos.direccion = resDetCompra.datos[0].direccion;
                response.datos.importeTotal = resDetCompra.datos[0].importeTotal;
                response.datos.igv = resDetCompra.datos[0].igv;
                response.datos.descuento = resDetCompra.datos[0].descuento;
                response.datos.listaProductosFinales = resDetCompra.datos.Select(x => new DetalleProductoFinal()
                {
                    codProductoFinal = x.codProductoFinal,
                    nombreProductoFinal = x.nombreProductoFinal,
                    cantidad = x.cantidad,
                    precio = x.precio,
                    subtotal = x.subtotal
                }).ToList();

                return response;
            }
            catch (Exception e)
            {
                return new ObtenerDetalleVentaResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener detalle de venta."
                };
            }
        }
    }
}
