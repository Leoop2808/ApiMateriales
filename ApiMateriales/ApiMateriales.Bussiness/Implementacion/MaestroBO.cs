using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.Entities.Maestro.Response;
using System;
using System.Collections.Generic;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class MaestroBO : IMaestroBO
    {
        private readonly IMaestroDO _maestroDO;
        public MaestroBO(IMaestroDO maestroDO)
        {
            _maestroDO = maestroDO;
        }
        public ObtenerListaMaestrosResponse ObtenerListaMaestros(int id_usuario) 
        {
            try
            {
                var response = new ObtenerListaMaestrosResponse()
                {
                    codigo = 1,
                    descripcion = "Datos de maestros obtenidos correctamente.",
                    datos = new ListadoMaestros()
                };
                ListadoDatosMaestrosFillData(response, id_usuario);

                return response;
            }
            catch (Exception e)
            {
                return new ObtenerListaMaestrosResponse()
                {
                    codigo = -1,
                    descripcion = "Error interno al obtener maestros."
                };
            }
        }
        public void ListadoDatosMaestrosFillData(ObtenerListaMaestrosResponse response,int id_usuario) 
        {
            var dataPais = _maestroDO.ObtenerPais(id_usuario);
            if (dataPais != null && dataPais.codigo == 1)
            {
                response.datos.listaPais = new List<DataPais>();
                response.datos.listaPais = dataPais.datos;
            }
            else
            {
                response.descripcion = dataPais.descripcion;
            }

            var dataProducto = _maestroDO.ObtenerProducto(id_usuario);
            if (dataProducto != null && dataProducto.codigo == 1)
            {
                response.datos.listaProducto = new List<DataProducto>();
                response.datos.listaProducto = dataProducto.datos;
            }
            else
            {
                response.descripcion = dataProducto.descripcion;
            }

            var dataProductoFinal = _maestroDO.ObtenerProductoFinal(id_usuario);
            if (dataProductoFinal != null && dataProductoFinal.codigo == 1)
            {
                response.datos.listaProductoFinal = new List<DataProductoFinal>();
                response.datos.listaProductoFinal = dataProductoFinal.datos;
            }
            else
            {
                response.descripcion = dataProductoFinal.descripcion;
            }

            var dataEstadoProduccion = _maestroDO.ObtenerEstadoProduccion(id_usuario);
            if (dataEstadoProduccion != null && dataEstadoProduccion.codigo == 1)
            {
                response.datos.listaEstadoProduccion = new List<DataEstadoProduccion>();
                response.datos.listaEstadoProduccion = dataEstadoProduccion.datos;
            }
            else
            {
                response.descripcion = dataEstadoProduccion.descripcion;
            }
        }
    }
}
