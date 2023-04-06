using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.DataAccess.Concrete.EntityFramework.Context;
using TouristProject.Entities.Concrete;

namespace TouristProject.Business.Configuration
{
    public class ConfigureRepositories
    {
        public static void AddService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TouristProjectContext>((option) =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });


            services.AddIdentity<User, Role>(option =>
            {
                option.Password.RequiredLength = 6; //6 karakter gerekli
                option.Password.RequireDigit = false; //
                option.Password.RequiredUniqueChars = 0;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireLowercase = false;
                option.Password.RequireUppercase = false;
                //User Username and email options
                option.User.AllowedUserNameCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-._@+";
                option.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<TouristProjectContext>();

            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.HttpOnly = true; //ilgili cookie başka yerden çekilemez
                option.Cookie.SameSite = SameSiteMode.Strict; //cookie sadece ilgili domainde kullanılabilir
                option.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; // Httpve Https de çalışsın
                option.Cookie.Name = "WhatCanIDoInIstanbul";
                option.ExpireTimeSpan = TimeSpan.FromDays(25); // ilgili kullanıcının cookie bilgisini 25 gün sakla
                option.LoginPath = new PathString("/Account/Unauthorize"); //cookie olmayan bir talep olursa bu sayfaya yönlendir.

            });

            services.AddScoped<DbContext, TouristProjectContext>();



        }
        //AddTransient:yukardaki nesneleri her kullanımıda  tekrar cagırma işlemini yapar tekrar tekrar her istekte nesne olusur kısacası 





    }
}
