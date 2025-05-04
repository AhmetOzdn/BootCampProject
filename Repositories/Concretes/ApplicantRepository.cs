using Core.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Entities;
using Repositories.Abstacts;
using Repositories.Concretes.EntityFramework.Contexts;
namespace Repositories.Concretes
{
    public class ApplicantRepository : EfRepositoryBase<Applicant, Guid, BaseDbContext> ,IApplicantRepository
    {
        public ApplicantRepository(BaseDbContext context) : base(context)
        {

        }
    }
}
