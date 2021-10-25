using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

namespace SoGest.Data.Repositories
{
    public class AlmacenRepository:GenericReopsitory<Almacen>,IAlmacenRepository
    {
       
        public AlmacenRepository (ISoGestRepositoryContext dbContext):base (dbContext)
        {
           
        }
    }
}
