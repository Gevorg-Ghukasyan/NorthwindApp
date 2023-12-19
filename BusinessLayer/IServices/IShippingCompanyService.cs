using BL.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.IServices
{
    public interface IShippingCompanyService
    {

        void AddShippingCompany(ShippingCompanyVM shippingComapny);
        Task AddShippingCompanyAsync(ShippingCompanyVM shippingComapny);


    }
}
