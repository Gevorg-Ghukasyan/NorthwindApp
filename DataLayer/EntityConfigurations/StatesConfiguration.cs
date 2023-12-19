using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class StatesConfiguration : EntityConfiguration<States>
    {
        public override void Configure(EntityTypeBuilder<States> builder)
        {
            base.Configure(builder);
            builder.ToTable("States");

            builder.Property(p => p.StateName)
                .HasMaxLength(255);
            

        }
    }
}
