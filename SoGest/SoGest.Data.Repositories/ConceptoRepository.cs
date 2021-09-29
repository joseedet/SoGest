using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.Data.Repositories
{
    public class ConceptoRepository : GenericReopsitory<Concepto>, IConceptoRepository
    {
        public ConceptoRepository ( ISoGestRepositoryContext dbContext ) : base(dbContext)
        {


        }
    }
}
