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
    public class OrdersConfiguration : AuditableEntityConfiguration<Orders>
    {
        public override void Configure(EntityTypeBuilder<Orders> builder)
        {
            base.Configure(builder);
            builder.ToTable("Orders");

            builder.HasOne(o => o.Employees)
                .WithMany(e => e.Orders)
                .HasForeignKey(o => o.EmployeeId);

            builder.HasOne(o => o.Company)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);

            builder.HasOne(o => o.ShippingComapny)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShipperId);

            builder.HasOne(o => o.TaxStatus)
                .WithMany(t => t.Orders)
                .HasForeignKey(o => o.TaxStatusId);

            builder.HasOne(o => o.OrderStatus)
                .WithMany(os => os.Orders)
                .HasForeignKey(o => o.OrderSatusId);
        }
    }
}
