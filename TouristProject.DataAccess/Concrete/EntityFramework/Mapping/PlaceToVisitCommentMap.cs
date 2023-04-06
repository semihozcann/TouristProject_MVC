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
    public class PlaceToVisitCommentMap : IEntityTypeConfiguration<PlaceToVisitComment>
    {
        public void Configure(EntityTypeBuilder<PlaceToVisitComment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.PlaceToVisitId).IsRequired();
            builder.Property(p => p.Comment).IsRequired();
            builder.Property(p => p.Comment).HasMaxLength(400);
            builder.Property(p => p.Point).IsRequired();
            builder.ToTable("PlaceToVisitComments");
        }
    }
}
