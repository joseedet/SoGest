using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SoGest.Data.Interaces;
using SoGest.Data.Repositories.Context;

namespace SoGest.Infrasturcture.DependencyInjection.Modules
{
    public class RepositoryModule
    {
        public static void Configure ( IServiceCollection services, IConfiguration configuration )
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<SoGestDBContext>(
                options => options.UseSqlServer(
                    connectionString,
                    sqlserveroptions => sqlserveroptions.MigrationsAssembly("SoGest.Data.Repositories"
                    /*sqlserverOptions.MigrationsAssembly("BlogEngine.Data.Repositories"*/)));

            services.AddScoped<ISoGestRepositoryContext, SoGestDBContext>( );
            services.AddScoped<IUnitOfWork>(unit => new UnitOfWork(unit.GetService<IBlogEngineRepositoryContext>( )));

            services.AddScoped<IPostRepository, PostRepository>( );
            services.AddScoped<IPromptRepository, PromptRepository>( );
        }
    }
}
