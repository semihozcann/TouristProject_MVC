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
    public class PlaceToVisitImageMap : IEntityTypeConfiguration<PlaceToVisitImage>
    {
        public void Configure(EntityTypeBuilder<PlaceToVisitImage> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.Property(p => p.PlaceToVisitId).IsRequired();
            builder.ToTable("PlaceToVisitImages");
        }
    }
}
