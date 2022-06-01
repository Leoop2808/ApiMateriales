namespace ApiMateriales.Entities.Contacto.Response
{
    public class ObtenerDetalleProveedorResponse : GeneralResponse
    {
        public DetalleProveedor datos { get; set; }
    }

    public class DetalleProveedor 
    {
        public string codPais { get; set; }
        public string nombreProveedor { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string representante { get; set; }
        public string celularRepre { get; set; }
        public string correoRepre { get; set; }
    }  
}
