using Business.Dtos.Request.Applicant;
using Business.Dtos.Response.Applicant;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicantService
    {
        CreatedApplicantResponse Add(CreateApplicantRequest request);
        List<Applicant> GetAll();
        void Update(Applicant applicant);
        void Delete(Guid applicantId);

    }
}
