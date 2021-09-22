using Microsoft.EntityFrameworkCore;

using SoGest.Data.Model.Entities;

namespace SoGest.Data.Interaces
{
    public interface ISoGestRepositoryContextcs:ISoGestDbContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Proveedor> Proveedores { get; set; }

        DbSet<TEntity> Set<TEntity> () where TEntity : class;

    }
}
