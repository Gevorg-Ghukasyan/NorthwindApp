﻿using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrderDetails : AuditableEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public ushort Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int OrderDetailStatusId { get; set; }

        public Orders Order { get; set; }
        public Product Product { get; set; }
        public OrderDetailStatus OrderDetailStatus { get; set; }
    }
}
