using SoGest.Data.Interaces;
using SoGest.Data.Model.Interfaces;

namespace SoGest.Data.Repositories
{
    public class ClienteRepository:GenericReopsitory<Cliente>,IClienteRepository
    {
        public ClienteRepository(ISoGestRepositoryContext dbContext):base(dbContext)
        {


        }
    }
}
