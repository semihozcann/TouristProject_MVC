using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TouristProject.Entities.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
        }
    }
}
