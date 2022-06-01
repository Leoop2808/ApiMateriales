using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Facturacion.Request;
using ApiMateriales.Entities.Facturacion.Response;
using System;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class FacturacionBO : IFacturacionBO
    {
        private readonly IFacturacionDO _facturacionDO;
        public FacturacionBO(IFacturacionDO facturacionDO)
        {
            _facturacionDO = facturacionDO;
        }

        public RegistrarVentaResponse RegistrarVenta(RegistrarVentaRequest request, int id_usuario) 
        {
            try
            {
                //return _facturacionDO.RegistrarVenta(request, id_usuario);
                return new RegistrarVentaResponse();
            }
            catch (Exception e)
            {
                return new RegistrarVentaResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el registro de venta."
                };
            }
        }
    }
}
