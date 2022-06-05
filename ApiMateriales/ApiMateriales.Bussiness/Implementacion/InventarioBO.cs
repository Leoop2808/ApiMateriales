using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Inventario.Request;
using ApiMateriales.Entities.Inventario.Response;
using System;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class InventarioBO : IInventarioBO
    {
        private readonly IInventarioDO _inventarioDO;
        public InventarioBO(IInventarioDO inventarioDO)
        {
            _inventarioDO = inventarioDO;
        }
        public ObtenerFlujoProductoFinalResponse ObtenerFlujoProductoFinal(ObtenerFlujoProductoFinalRequest request, int id_usuario)
        {
            try
            {
                return _inventarioDO.ObtenerFlujoProductoFinal(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerFlujoProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de obtener flujo producto final."
                };
            }
        }
        public ObtenerFlujoProductoResponse ObtenerFlujoProducto(ObtenerFlujoProductoRequest request, int id_usuario)
        {
            try
            {
                return _inventarioDO.ObtenerFlujoProducto(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerFlujoProductoResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de obtener flujo producto."
                };
            }
        }
        public ActualizarPrecioProductoFinalResponse ActualizarPrecioProductoFinal(ActualizarPrecioProductoFinalRequest request, int id_usuario) 
        {
            try
            {
                return _inventarioDO.ActualizarPrecioProductoFinal(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ActualizarPrecioProductoFinalResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de actualizar precio de producto final."
                };
            }
        }
        public ObtenerStocksProductosFinalesResponse ObtenerStocksProductosFinales(ObtenerStocksProductosFinalesRequest request, int id_usuario)
        {
            try
            {
                return _inventarioDO.ObtenerStocksProductosFinales(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerStocksProductosFinalesResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de obtener stocks productos finales."
                };
            }
        }
        public ObtenerStocksProductosResponse ObtenerStocksProductos(ObtenerStocksProductosRequest request, int id_usuario)
        {
            try
            {
                return _inventarioDO.ObtenerStocksProductos(request, id_usuario);
            }
            catch (Exception e)
            {
                return new ObtenerStocksProductosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno en el servicio de obtener stocks productos."
                };
            }
        }
    }
}
