namespace ApiMateriales.Entities.Produccion.Request
{
    public class RegistrarProduccionRequest
    {
        public string fechaInicio { get; set; }
        public string fechaComprometida { get; set; }
        public string codProductoFinal { get; set; }
        public int cantidad { get; set; }
    }
}
