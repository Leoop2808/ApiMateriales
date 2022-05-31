using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.Bussiness.Implementacion;
using ApiMateriales.DataAccess.Contrato;
using ApiMateriales.DataAccess.Implementacion;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace ApiMateriales
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            #region Business
            container.RegisterType<ICompraBO, CompraBO>();
            container.RegisterType<IContactoBO, ContactoBO>();
            container.RegisterType<IFacturacionBO, FacturacionBO>();
            container.RegisterType<IMaestroBO, MaestroBO>();
            container.RegisterType<IProduccionBO, ProduccionBO>();
            container.RegisterType<IProductoBO, ProductoBO>();
            container.RegisterType<IReporteBO, ReporteBO>();
            #endregion

            #region DataAccess
            container.RegisterType<ICompraDO, CompraDO>();
            container.RegisterType<IContactoDO, ContactoDO>();
            container.RegisterType<IFacturacionDO, FacturacionDO>();
            container.RegisterType<IMaestroDO, MaestroDO>();
            container.RegisterType<IProduccionDO, ProduccionDO>();
            container.RegisterType<IProductoDO, ProductoDO>();
            container.RegisterType<IReporteDO, ReporteDO>();
            #endregion

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}