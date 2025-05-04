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
    public class BlackListRepository : EfRepositoryBase<Blacklist, Guid, BaseDbContext> ,IBlackListRepository
    {
        public BlackListRepository(BaseDbContext context) : base(context)
        {

        }
    }
}
