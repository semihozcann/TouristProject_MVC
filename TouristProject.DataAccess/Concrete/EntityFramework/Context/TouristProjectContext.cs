using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TouristProject.DataAccess.Concrete.EntityFramework.Mapping;
using TouristProject.Entities.Concrete;
using TouristProject.Shared.Entities;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Context
{
    public class TouristProjectContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {


        public TouristProjectContext()
        {

        }

        //configuration from settings
        public TouristProjectContext(DbContextOptions<TouristProjectContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=TouristProjectDb;Trusted_Connection=true");

            }
            base.OnConfiguring(optionsBuilder);



        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<NutrientComment> NutrientComments { get; set; }
        public DbSet<NutrientFavorite> NutrientFavorites { get; set; }
        public DbSet<PlaceToVisit> PlaceToVisits { get; set; }
        public DbSet<PlaceToVisitComment> PlaceToVisitComments { get; set; }
        public DbSet<PlaceToVisitFavorite> PlaceToVisitFavorites { get; set; }

        //db kurallarını burada db olusturken veriyoruz. 
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new UserTokenMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserClaimMap());

            builder.ApplyConfiguration(new CategoryMap());

            builder.ApplyConfiguration(new NutrientMap());
            builder.ApplyConfiguration(new NutrientCommentMap());
            builder.ApplyConfiguration(new NutrientFavoriteMap());

            builder.ApplyConfiguration(new PlaceToVisitMap());
            builder.ApplyConfiguration(new PlaceToVisitCommentMap());
            builder.ApplyConfiguration(new PlaceToVisitFavoriteMap());


        }

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    //ChangeTracker mekanizması varlıkların durumlarını takip eden bir yapıdır. Bu sayede işlem yaparken varlıklar üzerinde ne işlem yapıldığını anlayabilir. Burada Bundan faydalanarak varlıklar üzerindeki değişime göre işlem esnasında yapılmasını istediğimiz eylemleri gereçekleştirebiliriz.
        //    var datas = ChangeTracker.Entries<BaseEntity>(); // varlığın yakalanması
        //    foreach (var data in datas)
        //    {
        //        _ = data.State switch
        //        {
        //            EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow, //ekleme işlemi ise işlem anındaki tarihi CreatedDate stununa ekle
        //            EntityState.Modified => data.Entity.ModifiedDate = DateTime.UtcNow, //Güncelleme işlemi ise işlem anındaki tarihi UpdatedDate stununa ekle

        //            //Bu kısıma işlem anında yapılmasını istediğiniz şeyleri ekleyebilirsiniz.
        //        };
        //    }
        //    return base.SaveChangesAsync(cancellationToken); //Değişiklikleri kaydet
        //}
    }
}
