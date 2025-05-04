using Business.Dtos.Request.Instructor;
using Business.Dtos.Request.User;
using Business.Dtos.Response.Instructor;
using Business.Dtos.Response.User;
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
        UpdatedInstructorResponse Update(UpdateInstructorRequest instructorId);
        DeletedInstructorResponse Delete(DeleteInstructorRequest instructorId);
    }
}
