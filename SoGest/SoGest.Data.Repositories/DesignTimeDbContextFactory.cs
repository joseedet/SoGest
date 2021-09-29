using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using SoGest.Data.Repositories.Context;

namespace SoGest.Data.Repositories
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SoGestDBContext>
    {
        public SoGestDBContext CreateDbContext ( string [] args )
        {
            var builder = new DbContextOptionsBuilder<SoGestDBContext>( );

            builder.UseSqlServer(@"Servere=MORFEO\\GHOST;Database=AdaiaCommerce;User id=sa Password=Adaia0311Edet;MultipleActiveResultSets=True;App=EntityFramework");

            return new SoGestDBContext(builder.Options);
        }
    }
}
