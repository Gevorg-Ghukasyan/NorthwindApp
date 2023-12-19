using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models.VM
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public string ProductCategoryName { get; set; }
        public int ProductCategoriesId { get; set; }
        public byte[] ProductCategoryImage { get; set; }
        
    }
    
}
