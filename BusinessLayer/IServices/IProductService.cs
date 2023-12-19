using BL.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.IServices
{
    public interface IProductService
    {

        public ProductVM GetProduct(int id);
        public Task<ProductVM> GetProductAsync(int id);
        public IEnumerable<ProductVM> GetAll();
        public Task<IEnumerable<ProductVM>> GetAllAsync();
        public ProductVM FirstOrDefaultProduct();
        public ProductVM SingleOrDefaultProduct(Expression<Func<ProductVM , bool>> predicate);
        public void AddProduct(ProductVM product);
        public Task AddProductAsync(ProductVM product);
        public void AddRangeProduct(IEnumerable<ProductVM> products);
        public Task AddRangeProductAsync(IEnumerable<ProductVM> products);
        public void RemoveProduct(ProductVM product);
        public Task RemoveProductAsync(ProductVM product);
        public void RemoveRangeProduct(IEnumerable<ProductVM> products);
        public Task RemoveRangeProductAsync(IEnumerable<ProductVM> products);
        public void DeleteProductById(int productId);
        public Task DeleteProductByIdAsync(int productId);
        public void UpdateProduct(ProductVM product);
        public Task UpdateProductAsync(ProductVM product);
        public void UpdateProductRange(IEnumerable<ProductVM> products);
        public Task UpdateProductRangeAsync(IEnumerable<ProductVM> products);
        public IEnumerable<ProductVM> FindProduct(Expression<Func<ProductVM, bool>> predicate);
        public Task<IEnumerable<ProductVM>> FindProductAsync(Expression<Func<ProductVM, bool>> predicate);
        public ProductVM FindDefaultProduct(params object?[]? keyValues);
        public Task<ProductVM> FindDefaultProductAsync(params object?[]? keyValues);
        public Task<IEnumerable<ProductVM>> FindProductsByVendorAsync(int vendorId);
        public int GetTotalStockQuantityOnHand();
        public Task<int> GetTotalStockQuantityOnHandAsync();
        public Task<IEnumerable<ProductVM>> FindProductsInOrdersAsync();
        public Task<IEnumerable<ProductVM>> FindProductsInCompletedOrdersAsync();


    }
}
