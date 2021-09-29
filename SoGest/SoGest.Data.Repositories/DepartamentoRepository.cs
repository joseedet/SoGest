using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGest.Data.Repositories
{
    public class DepartamentoRepository:GenericReopsitory<Departamento>,IDepartamentoRepository
    {
        public DepartamentoRepository(ISoGestRepositoryContext dbContext):base(dbContext)
        {


        }
    }
}
