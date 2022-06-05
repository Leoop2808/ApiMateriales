using System.Collections.Generic;

namespace ApiMateriales.Entities.Produccion.Response
{
    public class ObtenerListaProduccionesResponse : GeneralResponse
    {
        public List<DatosProduccion> datos { get; set; }        
    }
    public class DatosProduccion 
    {
        public int idProduccion { get; set; }
        public string codProductoFinal { get; set; }
        public string nombreProductoFinal { get; set; }
        public int cantidad { get; set; }
        public string fechaInicio { get; set; }
        public string fechaEntregaComprometida { get; set; }
        public string codEstadoProduccion { get; set; }
    }
}
