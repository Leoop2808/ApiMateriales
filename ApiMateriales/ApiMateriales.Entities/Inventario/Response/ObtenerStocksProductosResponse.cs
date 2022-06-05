using System.Collections.Generic;

namespace ApiMateriales.Entities.Inventario.Response
{
    public class ObtenerStocksProductosResponse : GeneralResponse
    {
        public List<DatosStockProducto> datos { get; set; }
    }
    public class DatosStockProducto 
    {
        public int idProducto { get; set; }
        public string codProducto { get; set; }
        public string nombreProducto { get; set; }
        public int stock { get; set; }
        public double precio { get; set; }
    }
}
