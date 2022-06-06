using System.Collections.Generic;

namespace ApiMateriales.Entities.Maestro.Response
{
    public class ObtenerProductosFinalesMasVendidosResponse : GeneralResponse
    {
        public List<DatosProductoFinalMasVendido> datos { get; set; }
    }
    public class DatosProductoFinalMasVendido 
    {
        public string nombreProductoFinal { get; set; }
        public int cantidadVentas { get; set; }
    }
}
