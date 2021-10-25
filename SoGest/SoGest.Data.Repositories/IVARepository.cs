using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.Data.Repositories
{
    public class IVARepository : GenericReopsitory<IVA>, IIvasRepository
    {
        public IVARepository ( ISoGestRepositoryContext dbContext ) : base(dbContext)
        {

        }
    }
}
