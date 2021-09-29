using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SoGest.Data.Repositories.Context;
using SoGest.Infrasturcture.DependencyInjection;

using System.Linq;

namespace SoGest.UI
{
    public class Startup
    {

        public IConfiguration Configuration { get; set; }

        public Startup ( IConfiguration Configuration )
        {
            this.Configuration = Configuration;
        }
        
        public void ConfigureServices ( IServiceCollection services )
        {
            services.RegisterServices(Configuration);
            services.AddMvc( );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure ( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if ( env.IsDevelopment( ) )
            {
                app.UseDeveloperExceptionPage( );
            }
            using ( var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>( ).CreateScope( ) )
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<SoGestDBContext>( );
                if ( context.Database.GetPendingMigrations( ).Any( ) )
                {
                    context.Database.Migrate( );
                }
            }

            app.UseRouting( );
            app.UseDefaultFiles( );
            app.UseStaticFiles( );
            app.UseAuthentication( );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers( );
            });
        }
    }
}
