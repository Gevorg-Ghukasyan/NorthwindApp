using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class PurchaseOrdersConfiguration : AuditableEntityConfiguration<PurchaseOrders>
    {
        public override void Configure(EntityTypeBuilder<PurchaseOrders> builder)
        {
            base.Configure(builder);
            builder.ToTable("PurchaseOrders");

            builder.HasOne(p => p.SupervisorEmployee)
                .WithMany(s => s.PurchaseOrders)
                .HasForeignKey(p => p.SubmittedById);

            builder.HasOne(p => p.PurchaseOrderStatus)
                .WithMany(p => p.PurchaseOrders)
                .HasForeignKey(p => p.StatusId);

            builder.HasOne(c => c.Company)
                .WithMany(p => p.PurchaseOrders)
                .HasForeignKey(p => p.VendorId);

            builder.HasOne(p => p.Employee)
                .WithMany(e => e.PurchaseOrders)
                .HasForeignKey(p => p.ApprovedById);

        }
    }
}
