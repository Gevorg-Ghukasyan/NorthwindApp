

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class TaxStatusConfiguration : AuditableEntityConfiguration<TaxStatus>
    {
        public override void Configure(EntityTypeBuilder<TaxStatus> builder)
        {
            base.Configure(builder);
            builder.ToTable("TaxStatus");


        }
    }
}
