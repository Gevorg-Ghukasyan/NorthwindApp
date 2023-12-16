using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrderStatus : AuditableEntity
    {
        public short OrderStatusCode { get; set; }
        public string OrderStatusName { get; set; }
        public bool SortOrder { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
