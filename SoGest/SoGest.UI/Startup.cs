using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using SoGest.Infrasturcture.DependencyInjection;

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
