using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MRU : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string TableName { get; set; } //
        public int? PKValue { get; set; }
        public DateTime DateAdded { get; set; }
        public Employees Employees { get; set; }
    }
}
