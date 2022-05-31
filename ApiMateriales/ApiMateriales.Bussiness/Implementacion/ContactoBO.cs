using ApiMateriales.Bussiness.Contrato;
using ApiMateriales.DataAccess.Contrato;

namespace ApiMateriales.Bussiness.Implementacion
{
    public class ContactoBO : IContactoBO
    {
        private readonly IContactoDO _contactoDO;
        public ContactoBO(IContactoDO contactoDO)
        {
            _contactoDO = contactoDO;
        }
    }
}
