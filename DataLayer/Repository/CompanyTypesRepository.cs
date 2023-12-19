using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CompanyTypesRepository : RepositoryBase<CompanyTypes>
    {
        public CompanyTypesRepository(AppDataBaseContext context) : base(context)
        {
        }
    }
}
