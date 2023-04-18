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
    public class NutrientImageMap : IEntityTypeConfiguration<NutrientImage>
    {
        public void Configure(EntityTypeBuilder<NutrientImage> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.ImageUrl).IsRequired();
            builder.Property(n => n.NutrientId).IsRequired();
            builder.ToTable("NutrientImages");
        }
    }
}
