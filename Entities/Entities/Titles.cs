using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Titles : AuditableEntity
    {
        public string TitleName { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
