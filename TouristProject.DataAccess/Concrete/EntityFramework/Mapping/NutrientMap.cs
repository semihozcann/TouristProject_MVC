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
    public class NutrientMap : IEntityTypeConfiguration<Nutrient>
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.CategoryId).IsRequired();
            builder.Property(n => n.Name).IsRequired();
            builder.Property(n => n.Name).HasMaxLength(50);
            builder.Property(n => n.Description).IsRequired();
            builder.Property(n => n.Description).HasMaxLength(400);
            builder.Property(n => n.SmallDescription).IsRequired();
            builder.Property(n => n.SmallDescription).HasMaxLength(50);
            builder.Property(n => n.Ingredients).IsRequired();
            builder.Property(n => n.Ingredients).HasMaxLength(400);
            builder.Property(n => n.ImagePath);
            builder.ToTable("Nutrients");


        }
    }
}
