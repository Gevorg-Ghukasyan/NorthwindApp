using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProductVendorRepository : RepositoryBase<ProductVendor>
    {
        public ProductVendorRepository(AppDataBaseContext context) : base(context)
        {
        }
    }
}
