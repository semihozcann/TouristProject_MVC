using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TouristProject.Business.Configuration;
using TouristProject.Business.DependencyResolvers;
using TouristProject.Business.DependencyResolvers.Autofac;
using TouristProject.Shared.DependencyResolvers;
using TouristProject.Shared.Extensions;
using TouristProject.Shared.Utilities.IoC;
using TouristProject.WebMVC.AutoMapper;
using TouristProject.WebMVC.Configurations;

namespace TouristProject.WebMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;

        }

        IWebHostEnvironment Env { get; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacBusinessModule());
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryViewModelProfile));
            ConfigureRepositories.AddService(services, Configuration);
            ConfigureDependencies.AddServices(services);
            var builder = services.AddControllersWithViews();

            #if DEBUG
            if (Env.IsDevelopment())
            {
                builder.AddRazorRuntimeCompilation();
            }
            #endif

            
            services.AddDependencyResolvers(new ICoreModule[]
            {
                new CoreModule(),
                new AutoMapperModule()
            });
        }




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); //access user info
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
