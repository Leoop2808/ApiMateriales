using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiMateriales.Entities.Facturacion.Request
{
    public class RegistrarVentaRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El cliente es obligatorio.")]
        public string codCliente { get; set; }
        public List<DatosProductoFinal> listaProductosFinales { get; set; }

        [Required(ErrorMessage = "El igv es obligatorio.")]
        public double igv { get; set; }

        [Required(ErrorMessage = "El importeTotal es obligatorio.")]
        public double importeTotal { get; set; }
    }

    public class DatosProductoFinal
    {
        public string codProductoFinal { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
    }
}
