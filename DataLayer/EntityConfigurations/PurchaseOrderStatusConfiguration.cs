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
    public class PurchaseOrderStatusConfiguration : AuditableEntityConfiguration<PurchaseOrderStatus>
    {
        public override void Configure(EntityTypeBuilder<PurchaseOrderStatus> builder)
        {
            base.Configure(builder);
            builder.ToTable("PurchaseOrderStatus");

            builder.Property(p => p.SortOrder)
                .HasDefaultValue(true);

        }
    }
}
