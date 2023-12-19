using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PurchaseOrderStatus : AuditableEntity
    {
        public string StatusName { get; set; }
        public bool SortOrder { get; set; }

        public ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}
