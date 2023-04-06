using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using TouristProject.Business.Abstract;
using TouristProject.Business.Concrete;
using TouristProject.WebMVC.Abstract;
using TouristProject.WebMVC.Helpers;

namespace TouristProject.WebMVC.Configurations
{
    public class ConfigureDependencies
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationManager>();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddTransient<IFileHelper, FileHelper>();


        }



    }
}
