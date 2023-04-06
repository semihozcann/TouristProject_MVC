using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristProject.Entities.Concrete;

namespace TouristProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class RoleClaimMap : IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            // Primary key
            builder.HasKey(rc => rc.Id);

            // Maps to the AspNetRoleClaims table
            builder.ToTable("AspNetRoleClaims");
        }
    }
}
