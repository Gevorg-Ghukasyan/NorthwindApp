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
    public class TitlesConfiguration : AuditableEntityConfiguration<Titles>
    {
        public override void Configure(EntityTypeBuilder<Titles> builder)
        {
            base.Configure(builder);
            builder.ToTable("Title");


        }
    }
}
