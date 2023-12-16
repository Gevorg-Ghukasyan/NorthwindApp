using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.EntityConfigurations
{
    public class PurchaseOrderDetailsConfiguration : AuditableEntityConfiguration<PurchaseOrderDetails>
    {
        public override void Configure(EntityTypeBuilder<PurchaseOrderDetails> builder)
        {
            base.Configure(builder);
            builder.ToTable("PurchaseOrderDetails");

            builder.Property(p => p.Quantity)
                .HasDefaultValue(1);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.PurchaseOrderDetails)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.PurchaseOrders)
                .WithMany(p => p.PurchaseOrderDetails)
                .HasForeignKey(p => p.PurchaseOrderId);


        }
    }
}
