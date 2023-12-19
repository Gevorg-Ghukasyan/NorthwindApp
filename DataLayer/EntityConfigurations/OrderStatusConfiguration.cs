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
    public class OrderStatusConfiguration : AuditableEntityConfiguration<OrderStatus>
    {
        public override void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            base.Configure(builder);
            builder.ToTable("OrderStatus");

            builder.Property(p => p.SortOrder)
                .HasDefaultValue(true);

        }
    }
}
