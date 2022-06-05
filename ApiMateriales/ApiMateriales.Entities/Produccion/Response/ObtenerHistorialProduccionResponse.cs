using System.Collections.Generic;

namespace ApiMateriales.Entities.Produccion.Response
{
    public class ObtenerHistorialProduccionResponse : GeneralResponse
    {
        public List<DatosHistorialProduccion> datos { get; set; }
    }
    public class DatosHistorialProduccion 
    {
        public int idProduccion { get; set; }
        public string codProductoFinal { get; set; }
        public string nombreProductoFinal { get; set; }
        public int cantidad { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFinalizada { get; set; }
        public string nombreEstadoProduccion { get; set; }
    }
}
