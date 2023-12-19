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
    public class OrdersRepository : RepositoryBase<Orders>, IOrdersRepository
    {
        public OrdersRepository(AppDataBaseContext context) : base(context)
        {

        }

        public async Task<Employees> GetEmployeeForOrderAsync(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.Employees)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            return order.Employees;
        }

        public async Task<ProductCompany> GetCustomerForOrderAsync(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.Company)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            return order.Company;
        }

        public async Task<ProductCompany> GetCompanyForOrderAsync(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.Company)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            return order.Company;
        }


        public async Task<IEnumerable<OrderDetails>> GetOrderDetailsByProductIdAsync(int productId)
        {
            return await _context.OrderDetails.Where(od => od.ProductId == productId).ToListAsync();
        }

        public async Task<IEnumerable<OrderDetails>> GetOrderDetailsByOrderIdAsync(int orderId)
        {
            return await _context.OrderDetails.Where(od => od.OrderId == orderId).ToListAsync();
        }

        public async Task<decimal> GetTotalOrderDetailsAmountAsync(int orderId)
        {
            return await _context.OrderDetails
                .Where(od => od.OrderId == orderId)
                .SumAsync(od => od.Quantity * od.UnitPrice);
        }
    }
}
