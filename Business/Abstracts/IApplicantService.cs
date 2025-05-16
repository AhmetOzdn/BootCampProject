using Business.Dtos.Request.Applicants;
using Business.Dtos.Response.Applicants;
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
        List<GetListApplicantResponse> GetList();
        UpdatedApplicantResponse Update(UpdateApplicantRequest request);
        DeletedApplicantResponse Delete(DeleteApplicantRequest request);

    }
}
