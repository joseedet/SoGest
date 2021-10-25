using SoGest.Data.Interaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGest.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISoGestDbContext _dbContext;
        public UnitOfWork (ISoGestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task ReloadEntites ()
        {
            await _dbContext.ReloadEntitiesAsync( );
        }

        public async Task<int> SaveChangesAsync ()
        {
            return await _dbContext.SaveChangesAsync( );
        }
    }
}
