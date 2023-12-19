using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orders : AuditableEntity
    {
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipperId { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal TaxRate { get; set; }
        public int TaxStatusId { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaidDate { get; set; }
        public string Notes { get; set; }
        public int OrderSatusId { get; set; }


        public ProductCompany Company { get; set; }
        public ShippingCompany ShippingComapny { get; set; }
        public TaxStatus? TaxStatus { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Employees Employees { get; set; }
    }
}
