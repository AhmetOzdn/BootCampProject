using Core.Repositories.EntityFramework;
using Entities;
using Repositories.Abstacts;
using Repositories.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes
{
    public class EmployeeRepository : EfRepositoryBase<Employee, Guid, BaseDbContext> ,IEmployeeRepository
    {
        public EmployeeRepository(BaseDbContext context) : base(context)
        {

        }
    }
}
