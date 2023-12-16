using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICompanyBaseEntity 
    {
        public string CompanyName { get; set; }
        public int CompanyTypeId { get; set; }
        public string BusinessPhone { get; set; }
        public string Address { get; set; } // modify
        public string City { get; set; }
        public int StateAbbrevId { get; set; } // Key
        public short Zip { get; set; }
        public string? WebsiteReference { get; set; }
        public string Notes { get; set; }
        public int StandardTaxStatusId { get; set; }

       
    }
}
