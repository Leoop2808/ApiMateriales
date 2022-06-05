namespace ApiMateriales.Entities.Produccion.Request
{
    public class ObtenerHistorialProduccionRequest
    {
        public string codProductoFinal { get; set; }
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
    }
}
