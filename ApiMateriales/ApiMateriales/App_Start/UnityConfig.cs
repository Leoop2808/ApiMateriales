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
            #endregion

            #region DataAccess
            #endregion

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}