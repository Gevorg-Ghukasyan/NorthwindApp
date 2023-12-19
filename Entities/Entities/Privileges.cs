using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Privileges : AuditableEntity
    {
        public string PrivilegeName { get; set; }

        public List<EmployeePrivileges> EmployeePrivileges { get; set; }

    }
}
