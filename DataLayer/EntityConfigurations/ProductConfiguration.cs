using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class ProductConfiguration : AuditableEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder) 
        {
            base.Configure(builder);
            builder.ToTable("Product");
            builder.Property(p => p.ProductName)
                .HasMaxLength(255);
            builder.Property(p => p.QuantityPerUnit)
                .HasDefaultValue(1);
            builder.Property(p => p.Discontinued)
                .HasDefaultValue(true);

            builder.HasOne(p => p.ProductCategory)
               .WithMany(p => p.Products)
               .HasForeignKey(p => p.ProductCategoryId);
            

           

        }
    }
}
