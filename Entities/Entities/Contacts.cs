using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Contacts : AuditableEntity
    {
        public int CompanyId { get; set; } // ShippingCompany , ProductComapny 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        [Phone]
        public string PrimaryPhone { get; set; }
        public string? SecondaryPhone { get; set; }
        public string Notes { get; set; }

        public ProductCompany? ProductCompany { get; set; }
        public ShippingCompany? ShippingComapny { get; set; }
    }
}
