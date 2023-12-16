using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace DAL.EntityConfigurations
{
    public class ProductCategoriesConfiguration : AuditableEntityConfiguration<ProductCategories>
    {
        public override void Configure(EntityTypeBuilder<ProductCategories> builder)
        {
            base.Configure(builder);
            builder.ToTable("ProductCategories");
            builder.HasKey(k => k.Id);
            builder.Property(p => p.ProductCategoryName)
                .HasMaxLength(255);


            

        }
    }
}
