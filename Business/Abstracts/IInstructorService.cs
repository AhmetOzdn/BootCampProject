using Business.Dtos.Request.Instructors;
using Business.Dtos.Response.Instructors;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        CreatedInstructorResponse Add(CreateInstructorRequest request);
        List<GetListInstructorResponse> GetList();
        UpdatedInstructorResponse Update(UpdateInstructorRequest request);
        DeletedInstructorResponse Delete(DeleteInstructorRequest request);
    }
}
