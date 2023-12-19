using Core.Entities;
using Core.Interfaces;
using DAL.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppDataBaseContext : DbContext
    {
        public AppDataBaseContext(DbContextOptions<AppDataBaseContext> options) : base(options)
        {
      //      Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new StockTakeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new ProductVendorConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
            modelBuilder.ApplyConfiguration(new MRUConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeePrivilegesConfiguration());
            modelBuilder.ApplyConfiguration(new PrivilegesConfiguration());
            modelBuilder.ApplyConfiguration(new TitlesConfiguration());
            modelBuilder.ApplyConfiguration(new SupervisorEmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ContactsConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyTypesConfiguration());
            modelBuilder.ApplyConfiguration(new StatesConfiguration());
            modelBuilder.ApplyConfiguration(new TaxStatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseOrdersConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseOrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseOrderDetailsConfiguration());
            /*  
               modelBuilder.SharedTypeEntity<IAuditableEntity>("AuditableColumns" , builder =>
               {
                   builder.Property<string>("AddedBy").IsRequired();
                   builder.Property<DateTime>("AddedOn").IsRequired();
               });
            */

        }

        public DbSet<Product> Product { get; set; } = null!;
        public DbSet<StockTake> StockTake { get; set; } = null!;
        public DbSet<ProductCategories> ProductCategories { get; set; } = null!;
        public DbSet<ProductVendor> ProductVendor { get; set; } = null!;
        public DbSet<Employees> Employees { get; set; } = null!;
        public DbSet<MRU> MRU { get; set; } = null!;
        public DbSet<EmployeePrivileges> EmployeePrivileges { get; set; }
        public DbSet<Privileges> Privileges { get; set; }
        public DbSet<Titles> Titles { get; set; } = null!;
        public DbSet<SupervisorEmployee> SupervisorEmployee { get; set; } = null!; 
        public DbSet<ProductCompany> ProductCompany { get; set; } = null!;
        public DbSet<ShippingCompany> ShippingComapny { get; set; } = null!;
        public DbSet<Contacts> Contacts { get; set; } = null!;
        public DbSet<CompanyTypes> CompanyTypes { get; set; } = null!;
        public DbSet<States> States { get; set; } = null!;
        public DbSet<TaxStatus> TaxStatus { get; set; } = null!;
        public DbSet<Orders> Orders { get; set; } = null!;
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; } = null!;
        public DbSet<OrderDetailStatus> OrderDetailStatus { get; set; }
        public DbSet<PurchaseOrders> PurchaseOrders { get; set; } = null!;
        public DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; } = null!;
        public DbSet<PurchaseOrderStatus> PurchaseOrderStatus { get; set; } = null!;



    }
}