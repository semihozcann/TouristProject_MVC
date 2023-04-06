using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PlaceToVisitFavoriteMap : IEntityTypeConfiguration<PlaceToVisitFavorite>
    {
        public void Configure(EntityTypeBuilder<PlaceToVisitFavorite> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.PlaceToVisitId).IsRequired();
            builder.ToTable("PlaceToVisitFavorities");
        }
    }
}
