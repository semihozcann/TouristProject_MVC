using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Business.Abstract;
using TouristProject.Business.Concrete;
using TouristProject.DataAccess.Abstract;
using TouristProject.DataAccess.Concrete.EntityFramework.Context;
using TouristProject.DataAccess.Concrete.EntityFramework.Repositories;
using TouristProject.Shared.Utilities.Interceptors;

namespace TouristProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<TouristProjectContext>().As<DbContext>().SingleInstance();


            builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            
            
            builder.RegisterType<EfNutrientRepository>().As<INutrientRepository>();
            builder.RegisterType<NutrientManager>().As<INutrientService>();






            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
