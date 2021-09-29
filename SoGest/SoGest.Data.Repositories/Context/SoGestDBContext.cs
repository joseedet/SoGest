using Microsoft.EntityFrameworkCore;

using SoGest.Data.Interaces;
using SoGest.Data.Model.Entities;

using System.Linq;
using System.Threading.Tasks;

namespace SoGest.Data.Repositories.Context
{
    public class SoGestDBContext : DbContext, ISoGestRepositoryContext, ISoGestDbContext
    {

        public SoGestDBContext ( DbContextOptions<SoGestDBContext> options ) : base(options)
        {
        }

        public DbSet<Almacen> Amacenes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Concepto> Conceptos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<IVA> IVAs { get; set; }
        public DbSet<Medida> Medidas { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        protected override void OnModelCreating ( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
        }
        public async Task ReloadEntitiesAsync ()
        {
            var entities = base.ChangeTracker.Entries( ).ToList( );
            foreach ( var entity in entities )
            {
                await entity.ReloadAsync( );
            }
        }
    }
}
