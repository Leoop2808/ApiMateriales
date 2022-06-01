using System.Collections.Generic;

namespace ApiMateriales.Entities.Contacto.Response
{
    public class ObtenerListaClientesResponse : GeneralResponse
    {
        public List<DataCliente> datos { get; set; }
    }
    public class DataCliente 
    {
        public int idCliente { get; set; }
        public string ruc { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
        public string representante { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
    }
}
