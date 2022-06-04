using System.Collections.Generic;

namespace ApiMateriales.Entities.Compra.Response
{
    public class ObtenerHistorialComprasResponse : GeneralResponse
    {
        public List<DatosHistorialCompra> datos { get; set; }
    }
    public class DatosHistorialCompra 
    {
        public int idCompra { get; set; }
        public string codCompra { get; set; }
        public string nombreProveedor { get; set; }
        public string fechaCompra { get; set; }
        public double importeTotal { get; set; }
    }
}
