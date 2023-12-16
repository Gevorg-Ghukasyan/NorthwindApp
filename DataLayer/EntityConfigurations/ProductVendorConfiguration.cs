using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.EntityConfigurations
{
    public class ProductVendorConfiguration : AuditableEntityConfiguration<ProductVendor>
    {
        public override void Configure(EntityTypeBuilder<ProductVendor> builder)
        {
            base.Configure(builder);
            builder.ToTable("ProductVendor");

            builder.HasOne(p => p.Product)
                .WithMany(p => p.ProductVendors)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Company)
                .WithMany(p => p.ProductVendors)
                .HasForeignKey(p => p.CompanyId);
        }
    }
}
