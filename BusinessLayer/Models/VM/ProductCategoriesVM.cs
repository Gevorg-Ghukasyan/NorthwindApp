using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models.VM
{
    public class ProductCategoriesVM
    {
        public string ProductCategoryName { get; set; }
        public string ProductCategoryCode { get; set; }
        public string? ProductCategoryDescription { get; set; }
        public string ProductCategoryImageName { get; set; }
        public byte[] ProductCategoryImage { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public string ImageUrl
        {
            get
            {
                if (ProductCategoryImage != null && ProductCategoryImage.Length > 0)
                {
                    var base64Image = Convert.ToBase64String(ProductCategoryImage);
                    var imageSrc = $"data:image/jpeg;base64,{base64Image}";
                    return imageSrc;
                }

                // Возвращаем путь к заглушке изображения, если изображение отсутствует
                return "/images/placeholder.jpg";
            }
        }

    }
}
