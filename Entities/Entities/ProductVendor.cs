using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductVendor : AuditableEntity
    {
        public int CompanyId { get; set; }
        public int ProductId { get; set; }

        public ProductCompany Company { get; set; }
        public Product Product { get; set; }
    }
}
