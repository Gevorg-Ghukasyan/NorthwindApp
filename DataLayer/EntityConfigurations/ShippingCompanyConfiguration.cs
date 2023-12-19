using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.EntityConfigurations
{
    public class ShippingCompanyConfiguration : AuditableEntityConfiguration<ShippingCompany>
    {
        public override void Configure(EntityTypeBuilder<ShippingCompany> builder)
        {
            base.Configure(builder);
            builder.ToTable("ShippingCompany");

            builder.HasOne(c => c.CompanyTypes)
                .WithMany(ct => ct.ShippingComapnies)
                .HasForeignKey(c => c.CompanyTypeId);

            builder.HasOne(c => c.StateAbbrev) // modify
                .WithMany(ct => ct.ShippingCompanies)
                .HasForeignKey(c => c.StateAbbrevId);

            builder.HasOne(c => c.TaxStatus)
                .WithMany(ct => ct.ShippingCompanies)
                .HasForeignKey(c => c.StandardTaxStatusId);


        }
    }
}
