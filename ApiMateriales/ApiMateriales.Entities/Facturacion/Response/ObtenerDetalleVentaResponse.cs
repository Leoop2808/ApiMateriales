using System.Collections.Generic;

namespace ApiMateriales.Entities.Facturacion.Response
{
    public class ObtenerDetalleVentaResponse : GeneralResponse
    {
        public DetalleVenta datos { get; set; }
    }
    public class DetalleVenta
    {
        public int idVenta { get; set; }
        public string codVenta { get; set; }
        public string fechaVenta { get; set; }
        public string nombreCliente { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public double igv { get; set; }
        public double importeTotal { get; set; }
        public double descuento { get; set; }
        public List<DetalleProductoFinal> listaProductosFinales { get; set; }
    }
    public class DetalleProductoFinal
    {
        public string codProductoFinal { get; set; }
        public string nombreProductoFinal { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
    }
    public class ObtenerDetalleVentaResponseOk : GeneralResponse
    {
        public List<DetalleVentaResponseOk> datos { get; set; }
    }
    public class DetalleVentaResponseOk : DetalleProductoFinal
    {
        public int idVenta { get; set; }
        public string codVenta { get; set; }
        public string fechaVenta { get; set; }
        public string nombreCliente { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public double igv { get; set; }
        public double importeTotal { get; set; }
        public double descuento { get; set; }
    }
}
