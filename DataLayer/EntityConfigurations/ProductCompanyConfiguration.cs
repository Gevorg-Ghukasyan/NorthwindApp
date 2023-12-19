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
    public class ProductCompanyConfiguration : CompanyBaseEntityConfiguration<ProductCompany>
    {
        public override void Configure(EntityTypeBuilder<ProductCompany> builder)
        {
            base.Configure(builder);
            builder.ToTable("ProductCompany");

            builder.HasOne(c => c.CompanyTypes)
              .WithMany(ct => ct.ProductCompanies)
              .HasForeignKey(c => c.CompanyTypeId);

            builder.HasOne(c => c.StateAbbrev) // modify
                .WithMany(ct => ct.ProductCompanies)
                .HasForeignKey(c => c.StateAbbrevId);

            builder.HasOne(c => c.TaxStatus)
                .WithMany(ct => ct.ProductCompanies)
                .HasForeignKey(c => c.StandardTaxStatusId);

        }
    }
}
