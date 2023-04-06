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
    public class PlaceToVisitMap : IEntityTypeConfiguration<PlaceToVisit>
    {
        public void Configure(EntityTypeBuilder<PlaceToVisit> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.PlaceName).IsRequired();
            builder.Property(p => p.PlaceName).HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(400);
            builder.Property(p => p.SmallDescription).IsRequired();
            builder.Property(p => p.SmallDescription).HasMaxLength(50);
            builder.Property(p => p.ImagePath);
            builder.Property(p => p.History).IsRequired();
            builder.Property(p => p.History).HasMaxLength(400);
            builder.Property(p => p.OpenTime).HasMaxLength(50);
            builder.Property(p => p.CloseTime).HasMaxLength(50);
            builder.Property(p => p.CloseDay).HasMaxLength(50);
            builder.ToTable("PlaceToVisits");
        }
    }
}
