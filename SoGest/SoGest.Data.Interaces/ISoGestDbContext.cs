using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.Threading;
using System.Threading.Tasks;

namespace SoGest.Data.Interaces
{
    public interface ISoGestDbContext
    {
        DbSet<TEntity> Set<TEntity> () where TEntity : class;
        Task<int> SaveChangesAsync ( CancellationToken cancellationToken = default(CancellationToken) );
        EntityEntry<TEntity> Entry<TEntity> ( TEntity entity ) where TEntity : class;
        Task ReloadEntitiesAsync ();
    }
}
