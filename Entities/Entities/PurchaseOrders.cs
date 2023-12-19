using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class PurchaseOrders : AuditableEntity
    {
        public int VendorId { get; set; }
        public int SubmittedById { get; set; }
        public DateTime SubmittedDate { get; set; }
        public int ApprovedById { get; set; }
        public DateTime AprrovedDate { get; set; }
        public int StatusId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }

        public PurchaseOrderStatus Status { get; set; }
        public Employees Employee { get; set; }
        public SupervisorEmployee SupervisorEmployee { get; set; }
        public PurchaseOrderStatus PurchaseOrderStatus { get; set; }
        public ProductCompany Company { get; set; }
        public ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }


    }
}
