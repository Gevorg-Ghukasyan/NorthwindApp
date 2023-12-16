using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class EmployeePrivilegesConfiguration : AuditableEntityConfiguration<EmployeePrivileges>
    {
        public override void Configure(EntityTypeBuilder<EmployeePrivileges> builder)
        {
            base.Configure(builder);
            builder.ToTable("EmployeePrivileges");

            builder.HasOne(ep => ep.Employee)
                .WithMany(e => e.EmployeePrivileges)
                .HasForeignKey(ep => ep.EmployeeId);

            builder.HasOne(ep => ep.Privilege)
               .WithMany(p => p.EmployeePrivileges)
               .HasForeignKey(ep => ep.PriviligeId);
        }
    }
}
