using System.Collections.Generic;

namespace ApiMateriales.Entities.Contacto.Response
{
    public class ObtenerListaProveedoresResponse : GeneralResponse
    {
        public List<DataProveedor> datos { get; set; }
    }
    public class DataProveedor
    {
        public int idProveedor { get; set; }
        public string ruc { get; set; }
        public string nombreProveedor { get; set; }
        public string direccion { get; set; }
        public string representante { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
    }
}
