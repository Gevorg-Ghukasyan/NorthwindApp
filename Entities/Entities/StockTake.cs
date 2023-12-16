using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class StockTake : AuditableEntity
    {
        public DateTime StockTakeDate { get; set; }
        public int ProductId { get; set; }
        public short QuantityOnHand { get; set; }
        public short ExpectedQuantity { get; set; }

        public Product Product { get; set; }
    }
}
