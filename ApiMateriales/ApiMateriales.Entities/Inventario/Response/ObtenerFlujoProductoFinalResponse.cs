using System.Collections.Generic;

namespace ApiMateriales.Entities.Inventario.Response
{
    public class ObtenerFlujoProductoFinalResponse : GeneralResponse
    {
        public List<DatosFlujoProductoFinal> datos { get; set; }
    }
    public class DatosFlujoProductoFinal
    {
        public int idProductoFinal { get; set; }
        public string codProductoFinal { get; set; }
        public string nombreProductoFinal { get; set; }
        public int cantidadSalidaProduccion { get; set; }
        public int cantidadVentas { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
