using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiMateriales.Entities.Compra.Request
{
    public class RegistrarCompraRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El proveedor es obligatorio.")]
        public string codProveedor { get; set; }
        public List<DatosProducto> listaProductos { get; set; }

        [Required(ErrorMessage = "El importeTotal es obligatorio.")]
        public double importeTotal { get; set; }
    }
    public class DatosProducto 
    {
        public string codProducto { get; set; }
        public int cantidad { get; set; }
        public double precioCompra { get; set; }
    }
}
