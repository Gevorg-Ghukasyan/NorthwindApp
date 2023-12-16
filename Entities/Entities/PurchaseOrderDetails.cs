using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PurchaseOrderDetails : AuditableEntity
    {
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public short Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public DateTime ReceivedDate { get; set; }

        public PurchaseOrders PurchaseOrders { get; set; }
        public Product Product { get; set; }
    }
}
