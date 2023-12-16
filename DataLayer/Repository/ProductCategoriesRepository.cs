using Core.Entities;
using Core.Interfaces.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductCategoriesRepository : RepositoryBase<ProductCategories> , IProductCategoriesRepository
    {
        public ProductCategoriesRepository(AppDataBaseContext context) : base(context)
        {

        }

        public ICollection<Product> GetProductsByCategoryById(int categoryId)
        {
            return _context.Product
                            .Where(p => p.ProductCategoryId == categoryId)
                            .ToList();
        }

        public async Task<ICollection<Product>> GetProductsByCategoryByIdAsync(int categoryId)
        {
            return await _context.Product
                            .Where(p => p.ProductCategoryId == categoryId)
                            .ToListAsync();
        }


        public ICollection<Product> GetProductsByCategory(string categoryName)
        {
            return _context.Product
                .Where(p => p.ProductCategory.ProductCategoryName == categoryName)
                .ToList();
        }

        public async Task<ICollection<Product>> GetProductsByCategoryAsync(string categoryName)
        {
            return await _context.Product
                .Where(p => p.ProductCategory.ProductCategoryName == categoryName)
                .ToListAsync();
        }
    }

}
