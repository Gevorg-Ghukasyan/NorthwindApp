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
    public class CompanyTypesConfiguration : AuditableEntityConfiguration<CompanyTypes>
    {

        public override void Configure(EntityTypeBuilder<CompanyTypes> builder)
        {
            base.Configure(builder);
            builder.ToTable("CompanyTypes");

        
        }
    }
}
