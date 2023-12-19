using Core.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Employees : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string? JobTitle { get; set; }

        [Phone]
        public string PrimaryPhone { get; set; }
        [Phone]
        public string? SecondaryPhone { get; set; }

        public string Notes { get; set; }
        //Attachments IFormFile
        public byte[]? FileData { get; set; }
        public string? FileName { get; set; }
        public string? FileType { get; set; }
        public int? SupervisorId { get; set; }
        public string WindowsUserName { get; set; }

        public int TitleId { get; set; } // modify   


        public SupervisorEmployee SupervisorEmployee { get; set; }
        public Titles Titles { get; set; }
        public virtual List<MRU>? MRUs { get; set; }
        public List<EmployeePrivileges> EmployeePrivileges { get; set; }
        public virtual ICollection<Orders>? Orders { get; set; }
        public virtual ICollection<PurchaseOrders>? PurchaseOrders { get; set;}



    }
}
