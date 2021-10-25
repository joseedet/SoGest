using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.Data.Repositories
{
    public class DepartamentoRepository:GenericReopsitory<Departamento>,IDepartamentoRepository
    {
        public DepartamentoRepository(ISoGestRepositoryContext dbContext):base(dbContext)
        {


        }
    }
}
