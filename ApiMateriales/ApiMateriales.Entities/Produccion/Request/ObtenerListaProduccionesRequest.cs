namespace ApiMateriales.Entities.Produccion.Request
{
    public class ObtenerListaProduccionesRequest
    {
        public string codEstadoProduccion { get; set; }
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
    }
}
