namespace ApiMateriales.Entities.Inventario.Request
{
    public class ObtenerFlujoProductoRequest
    {
        public string codProducto { get; set; }
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
    }
}
