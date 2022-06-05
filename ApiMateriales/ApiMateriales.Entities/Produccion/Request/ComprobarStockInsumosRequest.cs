namespace ApiMateriales.Entities.Produccion.Request
{
    public class ComprobarStockInsumosRequest
    {
        public string codProductoFinal { get; set; }
        public int cantidadProduccion { get; set; }
    }
}
