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
    public class StockTakeConfiguration : AuditableEntityConfiguration<StockTake>
    {
        public override void Configure(EntityTypeBuilder<StockTake> builder)
        {
            base.Configure(builder);
            builder.ToTable("StockTake");

            builder.HasOne(p => p.Product)
                .WithMany(p=> p.StockTake)
                .HasForeignKey(p => p.ProductId);

        }
    }
}
