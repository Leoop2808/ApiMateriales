namespace ApiMateriales.Entities.Produccion.Request
{
    public class ObtenerInsumosPorLingoteRequest
    {
        public string codProductoFinal { get; set; }
        public int cantidadProduccion { get; set; }
    }
}
