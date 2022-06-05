using System.Collections.Generic;

namespace ApiMateriales.Entities.Inventario.Response
{
    public class ObtenerStocksProductosFinalesResponse : GeneralResponse
    {
        public List<DatosStockProductoFinal> datos { get; set; }
    }
    public class DatosStockProductoFinal 
    {
        public int idProductoFinal { get; set; }
        public string codProductoFinal { get; set; }
        public int stock { get; set; }
        public double precio { get; set; }
    }
}
