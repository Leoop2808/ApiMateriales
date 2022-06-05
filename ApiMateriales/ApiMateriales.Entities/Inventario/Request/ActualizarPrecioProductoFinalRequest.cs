using System.ComponentModel.DataAnnotations;

namespace ApiMateriales.Entities.Inventario.Request
{
    public class ActualizarPrecioProductoFinalRequest
    {
        [Required(ErrorMessage = "El identificador del producto final es obligatorio.")]
        public int idProductoFinal { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio.")]
        public double precio { get; set; }
    }
}
