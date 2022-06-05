using System.Collections.Generic;

namespace ApiMateriales.Entities.Inventario.Response
{
    public class ObtenerFlujoProductoResponse : GeneralResponse
    {
        public List<DatosFlujoProducto> datos { get; set; }
    }
    public class DatosFlujoProducto 
    {
        public int idProducto { get; set; }
        public string codProducto { get; set; }
        public string nombreProducto { get; set; }
        public int cantidadCompras { get; set; }
        public int cantidadPaseProduccion { get; set; }
        public string fechaActualizacion { get; set; }
    }
}
