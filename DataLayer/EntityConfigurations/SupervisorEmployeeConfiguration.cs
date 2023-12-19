using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class SupervisorEmployeeConfiguration : AuditableEntityConfiguration<SupervisorEmployee>
    {
        public override void Configure(EntityTypeBuilder<SupervisorEmployee> builder)
        {
            base.Configure(builder);
            builder.ToTable("SupervisorEmployee");

            builder.Property(p => p.FirstName)
                .HasMaxLength(255);
            builder.Property(p => p.LastName)
                .HasMaxLength(255);

            builder.Property(p => p.EmailAddress)
                .IsRequired()
                .HasMaxLength(255)
                .HasConversion(email => email.ToLower(), email => email.ToLower());

            builder.HasMany(p => p.Employees)
                .WithOne(p => p.SupervisorEmployee)
                .HasForeignKey(p => p.SupervisorId);

            
             

        }
    }
}
