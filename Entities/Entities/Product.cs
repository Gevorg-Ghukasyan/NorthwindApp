using Core.Abstraction;
using Core.Interfaces;

namespace Core.Entities
{
    public class Product : AuditableEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal StandartUnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public short? ReorderLevel { get; set; }
        public short? TargetLevel { get; set; }
        public short QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
        public short MinimumReorderQuantitiy { get; set; }
        public int ProductCategoryId { get; set; }

        public ProductCategories ProductCategory { get; set; }
        public ICollection<ProductVendor> ProductVendors { get; set; }
        public ICollection<StockTake> StockTake { get; set; }
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
        public virtual ICollection<PurchaseOrderDetails>? PurchaseOrderDetails { get; set; }


    }
}
