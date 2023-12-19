using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.EntityConfigurations
{
    public class OrderDetailsConfiguration : AuditableEntityConfiguration<OrderDetails>
    {
        public override void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            base.Configure(builder);
            builder.ToTable("OrderDetails");

            builder.Property(p => p.Quantity)
                .HasDefaultValue(1);

            builder.HasOne(p => p.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Order)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderId);

            builder.HasOne(p => p.OrderDetailStatus)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderDetailStatusId);

        }
    }
}
