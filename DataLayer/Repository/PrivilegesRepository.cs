using Core.Entities;
using Core.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PrivilegesRepository : RepositoryBase<Privileges>, IPrivilegesRepository
    {
        public PrivilegesRepository(AppDataBaseContext context) : base(context)
        {

        }
    }
}
