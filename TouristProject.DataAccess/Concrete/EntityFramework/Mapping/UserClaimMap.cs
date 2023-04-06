using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TouristProject.Entities.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserClaimMap : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            // Primary key
            builder.HasKey(uc => uc.Id);

            // Maps to the AspNetUserClaims table
            builder.ToTable("AspNetUserClaims");
        }
    }
}
