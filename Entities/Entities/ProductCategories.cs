using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductCategories : AuditableEntity
    {
        public string ProductCategoryName { get; set; }
        public string ProductCategoryCode { get; set; }
        public string? ProductCategoryDescription { get; set; }
        public byte[] ProductCategoryImage { get; set; }
        public string ProductCategoryImageName { get; set; }
        public string ProductCateogryImageType { get; set; }
        /* 
        public ICollection<byte[]> ProductCategoryImages { get; set; }
        public ICollection<string> ProductCategoryImagesName { get; set; }
        public  ICollection<string> ProductCateogryImagesType {  get; set; }
        */

        public virtual ICollection<Product> Products { get; set; }

    }
}
