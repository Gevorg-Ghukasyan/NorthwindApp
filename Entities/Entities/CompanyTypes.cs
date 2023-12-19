using Core.Abstraction;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CompanyTypes : AuditableEntity
    {
      
        public ICollection<ProductCompany>? ProductCompanies { get; set; }
        public ICollection<ShippingCompany>? ShippingComapnies { get; set; }

        public string CompanyType { get; set; }

        /*public CompanyType CompanyType { get; set; }*/
    }

   /* public enum CompanyType
    {
        Corporation = 0,
        SoleProprietorship = 1,
        LLC = 2, // Limited Liability Company
        Partnership = 3,
        Individual = 4,
        Other = 5,
    }*/
}
