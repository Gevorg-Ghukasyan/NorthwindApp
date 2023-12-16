using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class EmployeePrivileges : AuditableEntity
    {
        public int EmployeeId { get; set; }
        public int PriviligeId { get; set; }

        public Employees Employee { get; set; }
        public Privileges Privilege { get; set; }
    }
}
