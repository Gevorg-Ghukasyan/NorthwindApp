using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class States : BaseEntity
    {
     /*   public int StateId { get; set; }*/ // StateAbbrev
        public string StateName { get; set; }

        public ICollection<ProductCompany>? ProductCompanies { get; set; }
        public ICollection<ShippingCompany>? ShippingCompanies { get; set; }

    }
}
