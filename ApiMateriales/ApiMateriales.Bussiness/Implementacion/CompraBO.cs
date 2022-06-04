using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Compra.Request;
using ApiMateriales.Entities.Compra.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class CompraBO : ICompraBO
    {
        private readonly ICompraDO _compraDO;
        public CompraBO(ICompraDO compraDO)
        {
            _compraDO = compraDO;
        }
        public RegistrarCompraResponse RegistrarCompra(RegistrarCompraRequest request, int id_usuario) 
        {
            try
            {
                DataTable dtCompraProducto = CrearDataTableCompraProducto();
                LlenarDataTableCompraProducto(dtCompraProducto, request.listaProductos);
                return _compraDO.RegistrarCompra(dtCompraProducto, request.codProveedor, request.importeTotal, id_usuario);
            }
            catch (Exception e)
            {
                return new RegistrarCompraResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el registro de compra."
                };
            }
        }
        public DataTable CrearDataTableCompraProducto()
        {
            DataTable dtVentaProductoFinal = new DataTable() { Locale = CultureInfo.InvariantCulture };
            dtVentaProductoFinal.Columns.Add("codProducto", typeof(string));
            dtVentaProductoFinal.Columns.Add("cantidad", typeof(int));
            dtVentaProductoFinal.Columns.Add("precioCompra", typeof(double));
            dtVentaProductoFinal.Columns.Add("numRegistroCompraProducto", typeof(int));

            return dtVentaProductoFinal;
        }
        public void LlenarDataTableCompraProducto(DataTable dtVentaProducto, List<DatosProducto> listaProductos)
        {
            int index = 0;
            foreach (var itemProducto in listaProductos)
            {
                dtVentaProducto.Rows.Add();
                dtVentaProducto.Rows[index]["codProducto"] = itemProducto.codProducto;
                dtVentaProducto.Rows[index]["cantidad"] = itemProducto.cantidad;
                dtVentaProducto.Rows[index]["precioCompra"] = itemProducto.precioCompra;
                dtVentaProducto.Rows[index]["numRegistroCompraProducto"] = index + 1;

                index++;
            }
        }
        public ObtenerHistorialComprasResponse ObtenerHistorialCompras(string nombreProveedor, int id_usuario) 
        {
            try
            {
                return _compraDO.ObtenerHistorialCompras(nombreProveedor, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerHistorialComprasResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener historial de compras."
                };
            }
        }
        public ObtenerDetalleCompraResponse ObtenerDetalleCompra(int idCompra, int id_usuario) 
        {
            try
            {
                var resDetCompra = _compraDO.ObtenerDetalleCompra(idCompra, id_usuario);
                if (resDetCompra.codigo != 1)
                {
                    return new ObtenerDetalleCompraResponse()
                    {
                        codigo = resDetCompra.codigo,
                        descripcion = resDetCompra.descripcion
                    };
                }

                var response = new ObtenerDetalleCompraResponse();
                response.codigo = 1;
                response.descripcion = "Detalle compra obtenido correctamente";
                response.datos = new DetalleCompra();
                response.datos.idCompra = resDetCompra.datos[0].idCompra;
                response.datos.codCompra = resDetCompra.datos[0].codCompra;
                response.datos.fechaCompra = resDetCompra.datos[0].fechaCompra;
                response.datos.nombreProveedor = resDetCompra.datos[0].nombreProveedor;
                response.datos.ruc = resDetCompra.datos[0].ruc;
                response.datos.direccion = resDetCompra.datos[0].direccion;
                response.datos.importeTotal = resDetCompra.datos[0].importeTotal;
                response.datos.listaProductos = resDetCompra.datos.Select(x => new DetalleProducto() {
                    codProducto = x.codProducto,
                    nombreProducto = x.nombreProducto,
                    cantidad = x.cantidad,
                    precioCompra = x.precioCompra,
                    subtotal = x.subtotal
                }).ToList();

                return response;
            }
            catch (Exception e)
            {
                return new ObtenerDetalleCompraResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener detalle de compra."
                };
            }
        }
    }
}
