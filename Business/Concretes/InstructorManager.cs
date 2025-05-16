using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Request.Instructors;
using Business.Dtos.Response.Bootcamps;
using Business.Dtos.Response.Instructors;
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
        private readonly IMapper _mapper;
        public InstructorManager(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public CreatedInstructorResponse Add(CreateInstructorRequest request)
        {
            //Manual Mapping
            //Instructor instructor = new Instructor
            //{
            //    UserName = request.UserName,
            //    FirstName = request.FirstName,
            //    LastName = request.LastName,
            //    Password = request.Password,
            //    Email = request.Email,
            //    CompanyName = request.CompanyName,
            //    NationalIdentity = request.NationalIdentity,
            //    DateOfBirth = request.DateOfBirth,
            //};
            //Instructor addedInstructor = _instructorRepository.Add(instructor);

            //return new CreatedInstructorResponse
            //{
            //    Id = addedInstructor.Id,
            //    CompanyName = addedInstructor.CompanyName,
            //    CreatedDate = addedInstructor.CreatedDate,
            //};


            //Using AutoMapper
            Instructor instructor = _mapper.Map<Instructor>(request);
            Instructor createdInstructor = _instructorRepository.Add(instructor);
            CreatedInstructorResponse response = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
            return response;
        }


        public List<GetListInstructorResponse> GetList()
        {
            //Manual Mapping
            //List<Instructor> instructors = _instructorRepository.GetAll();
            //List<GetListInstructorResponse> responses = new List<GetListInstructorResponse>();

            //foreach (var instructor in instructors)
            //{
            //    responses.Add(new GetListInstructorResponse
            //    {
            //        Id = instructor.Id,
            //        UserName = instructor.UserName,
            //        FirstName = instructor.FirstName,
            //        LastName = instructor.LastName,
            //        Email = instructor.Email,
            //        Password = instructor.Password,
            //        CompanyName = instructor.CompanyName,
            //        Bootcamps = instructor.Bootcamps?.Select(b => new BootcampDto
            //        {
            //            Id = b.Id,
            //            Name = b.Name
            //        }).ToList(),
            //        CreatedDate = instructor.CreatedDate,
            //        UpdatedDate = instructor.UpdatedDate ?? null,
            //        DeletedDate = instructor.DeletedDate ?? null
            //    });
            //}

            //return responses;

            //Using AutoMapper
            List<Instructor> instructors = _instructorRepository.GetAll();
            List<GetListInstructorResponse> responses = _mapper.Map<List<GetListInstructorResponse>>(instructors);
            return responses;
        }

        public UpdatedInstructorResponse Update(UpdateInstructorRequest request)
        {
            //Manual Mapping
            //Instructor selectedInstructor = _instructorRepository.Get(si => si.Id == request.Id);

            //if (selectedInstructor == null)
            //    throw new Exception("Eğitmen Bulunamadı");

            //selectedInstructor.UpdatedDate = DateTime.Now;
            //_instructorRepository.Update(selectedInstructor);

            //return new UpdatedInstructorResponse
            //{
            //    Id = selectedInstructor.Id,
            //    Message = "Eğitmen başarıyla Güncellendi"
            //};

            //Using AutoMapper
            Instructor selectedInstructor = _instructorRepository.Get(si => si.Id == request.Id);

            if (selectedInstructor == null)
                throw new Exception("Eğitmen Bulunamadı");

            _mapper.Map(request, selectedInstructor);
            _instructorRepository.Update(selectedInstructor);
            Instructor UpdatedInstructor = _instructorRepository.Update(selectedInstructor);
            UpdatedInstructorResponse response = _mapper.Map<UpdatedInstructorResponse>(UpdatedInstructor);
            return response;
        }

        public DeletedInstructorResponse Delete(DeleteInstructorRequest request)
        {
            //Manual Mapping
            //Instructor selectedInstructor = _instructorRepository.Get(si => si.Id == request.Id);

            //if (selectedInstructor == null)
            //    throw new Exception("Eğitmen Bulunamadı");

            //selectedInstructor.DeletedDate = DateTime.Now;
            //_instructorRepository.Delete(selectedInstructor);

            //return new DeletedInstructorResponse
            //{
            //    Id = selectedInstructor.Id,
            //    Message = "Eğitmen başarıyla silindi"
            //};

            //Using AutoMapper
            Instructor selectedInstructor = _instructorRepository.Get(si => si.Id == request.Id);

            if (selectedInstructor == null)
                throw new Exception("Eğitmen Bulunamadı");

            _mapper.Map(request, selectedInstructor);
            _instructorRepository.Delete(selectedInstructor);
            Instructor deletedInstructor = _instructorRepository.Delete(selectedInstructor);
            DeletedInstructorResponse response = _mapper.Map<DeletedInstructorResponse>(deletedInstructor);
            return response;


        }

    }
}
