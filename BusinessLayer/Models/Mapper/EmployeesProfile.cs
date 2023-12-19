using AutoMapper;
using BL.Models.VM;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models.Mapper
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile() 
        {
            CreateMap<EmployeesVM, Employees>();
            CreateMap<Employees, EmployeesVM>();
        }
    }
}
