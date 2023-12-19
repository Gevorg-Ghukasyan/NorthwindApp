using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrderDetailStatus : AuditableEntity
    {
        public string OrderDetailStatusName { get; set; }
        public bool SortOrder { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
