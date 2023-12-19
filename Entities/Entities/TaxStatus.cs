using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TaxStatus : AuditableEntity
    {
        public string StatusName { get; set; }
        public List<ProductCompany>? ProductCompanies { get; set; }
        public List<ShippingCompany>? ShippingCompanies { get; set; }
        public List<Orders>? Orders { get; set; }
    }
}
