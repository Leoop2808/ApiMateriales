using ApiMateriales.Bussiness.Contrato;
using System.Web.Http;

namespace ApiMateriales.Controllers
{
    [RoutePrefix("api/contacto")]
    public class ContactoController : ApiController
    {
        private readonly IContactoBO _contactoBO;
        public ContactoController(IContactoBO contactoBO)
        {
            _contactoBO = contactoBO;
        }
    }
}