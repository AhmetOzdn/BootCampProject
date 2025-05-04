using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Request.Instructor;
using Business.Dtos.Response.Bootcamp;
using Business.Dtos.Response.Instructor;
using Business.Dtos.Response.User;
using Entities;
using Repositories.Abstacts;
using Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;
        public InstructorManager(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public CreatedInstructorResponse Add(CreateInstructorRequest request)
        {
            Instructor instructor = new Instructor
            {
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Password = request.Password,
                Email = request.Email,
                CompanyName = request.CompanyName,
                NationalIdentity = request.NationalIdentity,
                DateOfBirth = request.DateOfBirth,
            };
            Instructor addedInstructor = _instructorRepository.Add(instructor);

            return new CreatedInstructorResponse
            {
                Id = addedInstructor.Id,
                CompanyName = addedInstructor.CompanyName,
                CreatedDate = addedInstructor.CreatedDate,
            };
        }


        public List<GetListInstructorResponse> GetList()
        {
            List<Instructor> instructors = _instructorRepository.GetAll();
            List<GetListInstructorResponse> responses = new List<GetListInstructorResponse>();

            foreach (var instructor in instructors)
            {
                responses.Add(new GetListInstructorResponse
                {
                    Id = instructor.Id,
                    UserName = instructor.UserName,
                    FirstName = instructor.FirstName,
                    LastName = instructor.LastName,
                    Email = instructor.Email,
                    Password = instructor.Password,
                    CompanyName = instructor.CompanyName,
                    Bootcamps = instructor.Bootcamps?.Select(b => new BootcampDto
                    {
                        Id = b.Id,
                        Name = b.Name
                    }).ToList(),
                    CreatedDate = instructor.CreatedDate,
                    UpdatedDate = instructor.UpdatedDate ?? null,
                    DeletedDate = instructor.DeletedDate ?? null
                });
            }

            return responses;
        }

        public DeletedInstructorResponse Delete(DeleteInstructorRequest instructorId)
        {
            Instructor selectedInstructor = _instructorRepository.Get(si => si.Id == instructorId.Id);

            if (selectedInstructor == null)
                throw new Exception("Eğitmen Bulunamadı");

            selectedInstructor.DeletedDate = DateTime.Now;
            _instructorRepository.Update(selectedInstructor);

            return new DeletedInstructorResponse
            {
                Id = selectedInstructor.Id,
                Message = "Eğitmen başarıyla silindi"
            };
        }


        public UpdatedInstructorResponse Update(UpdateInstructorRequest instructorId)
        {
            Instructor selectedInstructor = _instructorRepository.Get(si => si.Id == instructorId.Id);

            if (selectedInstructor == null)
                throw new Exception("Eğitmen Bulunamadı");

            selectedInstructor.UpdatedDate = DateTime.Now;
            _instructorRepository.Update(selectedInstructor);

            return new UpdatedInstructorResponse
            {
                Id = selectedInstructor.Id,
                Message = "Eğitmen başarıyla Güncellendi"
            };
        }
    }
}
