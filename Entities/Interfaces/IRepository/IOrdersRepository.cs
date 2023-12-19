using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IRepository
{
    public interface IOrdersRepository : IRepositoryBase<Orders>
    {
        Task<Employees> GetEmployeeForOrderAsync(int orderId);
        Task<ProductCompany> GetCustomerForOrderAsync(int orderId);
        Task<ProductCompany> GetCompanyForOrderAsync(int orderId);
        Task<IEnumerable<OrderDetails>> GetOrderDetailsByProductIdAsync(int productId);
        Task<IEnumerable<OrderDetails>> GetOrderDetailsByOrderIdAsync(int orderId);
        Task<decimal> GetTotalOrderDetailsAmountAsync(int orderId);

    }
}
