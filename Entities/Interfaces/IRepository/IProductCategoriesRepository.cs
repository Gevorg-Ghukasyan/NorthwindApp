using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IRepository
{
    public interface IProductCategoriesRepository : IRepositoryBase<ProductCategories>
    {
        ICollection<Product> GetProductsByCategoryById(int categoryId);
        Task<ICollection<Product>> GetProductsByCategoryByIdAsync(int categoryId);
        ICollection<Product> GetProductsByCategory(string categoryName);
        Task<ICollection<Product>> GetProductsByCategoryAsync(string categoryName);

      
    }
}
