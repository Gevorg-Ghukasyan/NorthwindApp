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
    public class ProductRepository : RepositoryBase<Product> , IProductRepository
    {
        public ProductRepository(AppDataBaseContext context) : base(context)
        {

        }


        public async Task<IEnumerable<Product>> FindProductsByVendorAsync(int vendorId)
        {
            return await FindAsync(p => p.ProductVendors
            .Any(pv => pv.CompanyId == vendorId));
        }


        public int GetTotalStockQuantityOnHand()
        {
            return GetSum(p => p.StockTake
            .Sum(st => st.QuantityOnHand));
        }

        public async Task<int> GetTotalStockQuantityOnHandAsync()
        {
            return await GetSumAsync(p => p.StockTake
            .Sum(st => st.QuantityOnHand));
        }

        public async Task<IEnumerable<Product>> FindProductsInOrdersAsync()
        {
            return await _context.Set<Product>()
                .Include(p => p.OrderDetails)
                .ThenInclude(od => od.Order)
                .ToListAsync();
        }


        public async Task<IEnumerable<Product>> FindProductsInCompletedOrdersAsync()
        {
            // example
            var completedStatusCode = 200;

            return await _context.Set<Product>()
                .Include(p => p.OrderDetails)
                .ThenInclude(od => od.Order)
                .Where(p => p.OrderDetails.Any(od => od.Order.OrderStatus.OrderStatusCode == completedStatusCode))
                .ToListAsync();
        }
    }
}
