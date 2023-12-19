using BL.Models.VM;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.IServices
{
    public interface IProductCategoriesService
    {
        void AddProductCategories(ProductCategoriesVM productCategory);
        Task AddProductCategoriesAsync(ProductCategoriesVM productCategory);
    }
}
