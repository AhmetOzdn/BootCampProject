using Core.Repositories.EntityFramework;
using Entities;
using Microsoft.EntityFrameworkCore.Query;
using Repositories.Abstacts;
using Repositories.Concretes.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes
{
    public class UserRepository : EfRepositoryBase<User, Guid, BaseDbContext> , IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {

        }
    }
}
