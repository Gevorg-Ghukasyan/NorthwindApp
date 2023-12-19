using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction
{
    public abstract class AuditableEntity : BaseEntity, IAuditableEntity
    {
        public string AddedBy { get; set; }
        public DateTime AddedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
