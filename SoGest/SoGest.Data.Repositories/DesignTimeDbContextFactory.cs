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

            builder.UseSqlServer(@"Data Source=MORFEO\DESARROLLO;Initial Catalog=Commerce;Integrated Security=true;MultipleActiveResultSets=True");

            return new SoGestDBContext(builder.Options);
        }
    }
}
