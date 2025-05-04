using Business.Dtos.Response.Application;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        CreatedApplicationResponse Add(CreatedApplicationResponse response);
        List<Application> GetAll();
        void Update(Application application);
        void Delete(Guid applicationId);
    }
}
