namespace ApiMateriales.Entities.Inventario.Request
{
    public class ObtenerFlujoProductoFinalRequest
    {
        public string codProductoFinal { get; set; }
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
    }
}
