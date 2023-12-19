using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ShippingCompany : CompanyBaseEntity
    {
        public States StateAbbrev { get; set; }
        public TaxStatus TaxStatus { get; set; } // ?
        public CompanyTypes CompanyTypes { get; set; }
        public ICollection<ProductVendor> ProductVendors { get; set; }
        public ICollection<Orders>? Orders { get; set; }
        public ICollection<Contacts> Contacts { get; set; }
        public ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}
