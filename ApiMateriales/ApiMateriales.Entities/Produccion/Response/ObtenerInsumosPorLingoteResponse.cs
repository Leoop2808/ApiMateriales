using System.Collections.Generic;

namespace ApiMateriales.Entities.Produccion.Response
{
    public class ObtenerInsumosPorLingoteResponse : GeneralResponse
    {
        public List<DatosInsumo> datos { get; set; }
    }
    public class DatosInsumo 
    {
        public int idProducto { get; set; }
        public string codProducto { get; set; }
        public string nombreProducto { get; set; }
        public string cantidadNecesaria { get; set; }
        public string nombreProductoFinal { get; set; }
    }
}
