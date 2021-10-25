using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.Data.Repositories
{
    public  class ProveedorRepository:GenericReopsitory<Proveedor>,IProveedorRepository
    {

        public ProveedorRepository (ISoGestRepositoryContext dbContext):base(dbContext)
        {

        }
    }
}
