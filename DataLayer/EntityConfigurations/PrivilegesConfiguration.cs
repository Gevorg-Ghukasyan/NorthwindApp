using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class PrivilegesConfiguration : AuditableEntityConfiguration<Privileges>
    {
        public override void Configure(EntityTypeBuilder<Privileges> builder)
        {
            base.Configure(builder);
            builder.ToTable("Privileges");

        }
    }
}
