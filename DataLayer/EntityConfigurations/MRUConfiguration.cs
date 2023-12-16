using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class MRUConfiguration : EntityConfiguration<MRU>
    {
        public override void Configure(EntityTypeBuilder<MRU> builder)
        {
            base.Configure(builder);
            builder.ToTable("MRU");

            builder.HasOne(m => m.Employees)
                .WithMany(p => p.MRUs)
                .HasForeignKey(m => m.EmployeeId);

        }
    }
}
