using System.Collections.Generic;

namespace ApiMateriales.Entities.Maestro.Response
{
    public class ObtenerProductosMasCompradosResponse : GeneralResponse
    {
        public List<DatosProductoMasComprado> datos { get; set; }
    }
    public class DatosProductoMasComprado 
    {
        public string nombreProducto { get; set; }
        public int cantidadCompras{ get; set; }
    }
}
