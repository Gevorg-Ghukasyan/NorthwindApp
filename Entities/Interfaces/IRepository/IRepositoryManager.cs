using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.IRepository
{
    public interface IRepositoryManager
    {
        public ICompanyTypesRepository CompanyTypes { get; set; }
        public IContactsRepository Contacts { get; set; }
        public IEmployeePrivilegesRepositroy EmployeePrivileges { get; set; }
        public IEmployeesRepository Employees { get; set; }
        public IMRURepository MRU { get; set; }
        public IOrderDetailsRepository OrderDetails { get; set; }
        public IOrderDetailStatusRepository OrderDetailStatus { get; set; }
        public IOrdersRepository Orders { get; set; }
        public IOrderStatusRepository OrdersStatus { get; set; }
        public IPrivilegesRepository Privileges { get; set; }
        public IProductCategoriesRepository ProductCategories { get; set; }
        public IProductCompanyRepository ProductCompany { get; set; }
        public IProductRepository Products { get; set; }
        public IProductVendorRepository ProductVendor { get; set; }
        public IPurchaseOrderDetailsRepository PurchaseOrderDetails { get; set; }
        public IPurchaseOrdersRepository PurchaseOrders { get; set; }
        public IPurchaseOrderStatusRepository PurchaseOrderStatus { get; set; }
        public IShippingCompanyRepository ShippingCompany { get; set; }
        public IStatesRepository States { get; set; }
        public IStockTakeRepository StockTake { get; set; }
        public ISupervisorEmployeeRepository SupervisorEmployee { get; set; }
        public ITaxStatusRepository TaxStatus { get; set; }
        public ITitlesRepositroy Titles { get; set; }
    }
}
