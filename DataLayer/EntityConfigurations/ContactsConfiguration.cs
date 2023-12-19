using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public class ContactsConfiguration : AuditableEntityConfiguration<Contacts>
    {
        public override void Configure(EntityTypeBuilder<Contacts> builder)
        {
            base.Configure(builder);
            builder.ToTable("Contacts");

            builder.Property(p => p.LastName)
                .HasMaxLength(255);
            builder.Property(p => p.FirstName)
                .HasMaxLength(255);

            builder.HasOne(p => p.ProductCompany)
               .WithMany(p => p.Contacts)
               .HasForeignKey(p => p.CompanyId);

            builder.HasOne(p => p.ShippingComapny)
                .WithMany(p => p.Contacts)
                .HasForeignKey(p => p.CompanyId);

        }
    }
}
