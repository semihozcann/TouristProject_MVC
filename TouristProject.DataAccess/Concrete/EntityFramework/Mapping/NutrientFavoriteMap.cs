﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class NutrientFavoriteMap : IEntityTypeConfiguration<NutrientFavorite>
    {
        public void Configure(EntityTypeBuilder<NutrientFavorite> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).ValueGeneratedOnAdd();
            builder.Property(n => n.UserId).IsRequired();
            builder.Property(n => n.NutrientId).IsRequired();
            builder.ToTable("NutrientFavorities");
        }
    }
}
