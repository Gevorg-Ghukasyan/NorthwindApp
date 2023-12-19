using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IRepository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        int GetTotalStockQuantityOnHand();
        Task<int> GetTotalStockQuantityOnHandAsync();

        Task<IEnumerable<Product>> FindProductsByVendorAsync(int vendorId);
        Task<IEnumerable<Product>> FindProductsInOrdersAsync();
        Task<IEnumerable<Product>> FindProductsInCompletedOrdersAsync();

    }
}
