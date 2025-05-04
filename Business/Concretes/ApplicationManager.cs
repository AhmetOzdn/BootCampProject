using Business.Abstracts;
using Business.Dtos.Response.Application;
using Entities;
using Repositories.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;

        public ApplicationManager(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public CreatedApplicationResponse Add(CreatedApplicationResponse response)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid applicationId)
        {
            throw new NotImplementedException();
        }

        public List<Application> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Application application)
        {
            throw new NotImplementedException();
        }
    }
}
