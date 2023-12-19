using Core.Abstraction;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityConfigurations
{
    public abstract class CompanyBaseEntityConfiguration<T> : AuditableEntityConfiguration<T> where T : CompanyBaseEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.CompanyName)
               .HasMaxLength(255);

           

        }
    }
}
