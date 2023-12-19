using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class EmployeesConfiguration : AuditableEntityConfiguration<Employees>
    {
        public override void Configure(EntityTypeBuilder<Employees> builder)
        {
            base.Configure(builder);
            builder.ToTable("Employees");

            builder.Property(p => p.FirstName).HasMaxLength(255);
            builder.Property(p => p.LastName).HasMaxLength(255);

            builder.Property(p => p.EmailAddress)
                .IsRequired()
                .HasMaxLength(255)
                .HasConversion(email => email.ToLower(), email => email.ToLower());

            builder.HasOne(p => p.Titles)
                .WithMany(p => p.Employees)
                .HasForeignKey(p => p.TitleId);


            
        }
    }
}
