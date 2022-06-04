using System.Collections.Generic;

namespace ApiMateriales.Entities.Facturacion.Response
{
    public class ObtenerHistorialVentasResponse : GeneralResponse
    {
        public List<DatosHistorialVenta> datos { get; set; }
    }
    public class DatosHistorialVenta
    {
        public int idVenta { get; set; }
        public string codVenta { get; set; }
        public string nombreCliente { get; set; }
        public string fechaVenta { get; set; }
        public double importeTotal { get; set; }
    }
}
