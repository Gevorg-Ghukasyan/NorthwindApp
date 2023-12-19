using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.EntityConfigurations
{
    public class OrderDetailStatusConfiguration : AuditableEntityConfiguration<OrderDetailStatus>
    {
        public override void Configure(EntityTypeBuilder<OrderDetailStatus> builder)
        {
            base.Configure(builder);
            builder.ToTable("OrderDetailStatus");


        }
    }
}
