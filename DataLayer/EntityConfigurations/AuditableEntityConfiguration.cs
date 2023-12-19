using Microsoft.EntityFrameworkCore;
using Core.Abstraction;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public abstract class AuditableEntityConfiguration<T> : EntityConfiguration<T> where T : AuditableEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.AddedBy)
                .IsRequired()
                .HasMaxLength(255);
            builder.Property(e => e.AddedOn)
                .IsRequired();
            builder.Property(e => e.ModifiedBy);
            builder.Property(e => e.ModifiedOn);

        }
    }
}
