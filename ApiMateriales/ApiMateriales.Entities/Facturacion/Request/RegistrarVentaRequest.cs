using System.Collections.Generic;

namespace ApiMateriales.Entities.Facturacion.Request
{
    public class RegistrarVentaRequest
    {
        public string codCliente { get; set; }
        public List<DatosProducto> listaProductos { get; set; }
        public double igv { get; set; }
        public double importeTotal { get; set; }
    }

    public class DatosProducto
    {
        public string codProducto { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
    }
}
