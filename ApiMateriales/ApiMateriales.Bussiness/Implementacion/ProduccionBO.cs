using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Produccion.Request;
using ApiMateriales.Entities.Produccion.Response;
using System;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class ProduccionBO : IProduccionBO
    {
        private readonly IProduccionDO _produccionDO;
        public ProduccionBO(IProduccionDO produccionDO)
        {
            _produccionDO = produccionDO;
        }
        public ObtenerListaProduccionesResponse ObtenerListaProducciones(ObtenerListaProduccionesRequest request, int id_usuario) 
        {
            try
            {
                return _produccionDO.ObtenerListaProducciones(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerListaProduccionesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de listar producciones."
                };
            }
        }
        public ObtenerInsumosPorLingoteResponse ObtenerInsumosPorLingote(ObtenerInsumosPorLingoteRequest request, int id_usuario) 
        {
            try
            {
                return _produccionDO.ObtenerInsumosPorLingote(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerInsumosPorLingoteResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de obtener insumos por lingote."
                };
            }
        }
        public ComprobarStockInsumosResponse ComprobarStockInsumos(ComprobarStockInsumosRequest request, int id_usuario) 
        {
            try
            {
                return _produccionDO.ComprobarStockInsumos(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ComprobarStockInsumosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de comprobar stock insumos."
                };
            }
        }
        public RegistrarProduccionResponse RegistrarProduccion(RegistrarProduccionRequest request, int id_usuario) 
        {
            try
            {
                return _produccionDO.RegistrarProduccion(request, id_usuario);
            }
            catch (Exception e)
            {
                return new RegistrarProduccionResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de registro de producción."
                };
            }
        }
    }
}
