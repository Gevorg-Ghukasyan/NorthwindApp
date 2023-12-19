using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models.VM
{
    public class ProductCompanyVM
    {
        public string CompanyName { get; set; }
        public int CompanyTypeId { get; set; }
        public string BusinessPhone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateAbbrevId { get; set; }
        public string StateAbbrevName { get; set; }
        public short Zip { get; set; }
        public string WebsiteReference { get; set; }
        public string Notes { get; set; }
        public int StandardTaxStatusId { get; set; }
        public string TaxStatusName { get; set; } // Свойство для имени налогового статуса
        public string CompanyTypeName { get; set; }
    }
}
