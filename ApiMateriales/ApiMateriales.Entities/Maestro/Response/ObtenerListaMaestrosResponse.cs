using System.Collections.Generic;

namespace ApiMateriales.Entities.Maestro.Response
{
    public class ObtenerListaMaestrosResponse : GeneralResponse
    {
        public ListadoMaestros datos { get; set; }
    }
    public class ListadoMaestros
    {
        public List<DataPais> listaPais { get; set; }
        public List<DataProducto> listaProducto { get; set; }
        public List<DataProductoFinal> listaProductoFinal { get; set; }
        public List<DataEstadoProduccion> listaEstadoProduccion { get; set; }
    }
    public class ObtenerPaisResponse : GeneralResponse
    {
        public List<DataPais> datos { get; set; }
    }
    public class DataPais
    {
        public string codPais{ get; set; }
        public string siglaPais { get; set; }
    }
    public class ObtenerProductoResponse : GeneralResponse
    {
        public List<DataProducto> datos { get; set; }
    }
    public class DataProducto 
    {
        public string codProducto { get; set; }
        public string nombreProducto { get; set; }
    }
    public class ObtenerProductoFinalResponse : GeneralResponse
    {
        public List<DataProductoFinal> datos { get; set; }
    }
    public class DataProductoFinal
    {
        public string codProductoFinal { get; set; }
        public string nombreProductoFinal { get; set; }
    }
    public class ObtenerEstadoProduccionResponse : GeneralResponse
    {
        public List<DataEstadoProduccion> datos { get; set; }
    }
    public class DataEstadoProduccion
    {
        public string codEstadoProduccion { get; set; }
        public string siglaEstadoProduccion { get; set; }
    }
}
