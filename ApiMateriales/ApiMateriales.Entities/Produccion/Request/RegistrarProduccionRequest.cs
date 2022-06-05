using System.ComponentModel.DataAnnotations;

namespace ApiMateriales.Entities.Produccion.Request
{
    public class RegistrarProduccionRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "La fecha de inicio es obligatoria.")]
        public string fechaInicio { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La fecha comprometida es obligatoria.")]
        public string fechaComprometida { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El producto final es obligatorio.")]
        public string codProductoFinal { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatorio.")]
        public int cantidad { get; set; }
    }
}
