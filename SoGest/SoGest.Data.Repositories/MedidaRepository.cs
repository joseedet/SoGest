using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.Data.Repositories
{
    public class MedidaRepository : GenericReopsitory<Medida>, IMedidaRepository
    {
        public MedidaRepository ( ISoGestRepositoryContext dbContext ) : base(dbContext)
        {

        }
    }
}
