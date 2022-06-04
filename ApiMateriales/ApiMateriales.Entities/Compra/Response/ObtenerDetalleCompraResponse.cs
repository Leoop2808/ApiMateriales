using System.Collections.Generic;

namespace ApiMateriales.Entities.Compra.Response
{
    public class ObtenerDetalleCompraResponse : GeneralResponse
    {
        public DetalleCompra datos { get; set; }        
    }
    public class DetalleCompra 
    {
        public int idCompra { get; set; }
        public string codCompra { get; set; }
        public string fechaCompra { get; set; }
        public string nombreProveedor { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public double importeTotal { get; set; }
        public List<DetalleProducto> listaProductos { get; set; }
    }
    public class DetalleProducto 
    {
        public string codProducto { get; set; }
        public string nombreProducto { get; set; }
        public int cantidad { get; set; }
        public double precioCompra { get; set; }
        public double subtotal { get; set; }
    }
    public class ObtenerDetalleCompraResponseOk : GeneralResponse
    {
        public List<DetalleCompraResponseOk> datos { get; set; }        
    }
    public class DetalleCompraResponseOk : DetalleProducto
    {
        public int idCompra { get; set; }
        public string codCompra { get; set; }
        public string fechaCompra { get; set; }
        public string nombreProveedor { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public double importeTotal { get; set; }
    }
}
