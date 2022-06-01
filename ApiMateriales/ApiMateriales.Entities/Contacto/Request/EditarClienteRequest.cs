using System.ComponentModel.DataAnnotations;

namespace ApiMateriales.Entities.Contacto.Request
{
    public class EditarClienteRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El país es obligatorio.")]
        public string codPais { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre de empresa es obligatorio.")]
        public string nombreCliente { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El RUC es obligatorio.")]
        public string ruc { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La dirección es obligatoria.")]
        public string direccion { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El representante es obligatorio.")]
        public string representante { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El celular del representante es obligatorio.")]
        public string celularRepre { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El correo del representante es obligatorio.")]
        public string correoRepre { get; set; }
    }
}
