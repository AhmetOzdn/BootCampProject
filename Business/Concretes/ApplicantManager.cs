using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request.Applicants;
using Business.Dtos.Response.Applicants;
using Business.Dtos.Response.Applications;
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
    public class ApplicantManager : IApplicantService
    {
        private readonly IApplicantRepository _applicantRepository;
        private readonly IMapper _mapper;

        public ApplicantManager(IApplicantRepository applicantRepository, IMapper mapper)
        {
            _applicantRepository = applicantRepository;
            _mapper = mapper;

        }

        public CreatedApplicantResponse Add(CreateApplicantRequest request)
        {
            //Using AutoMapper
            Applicant applicant = _mapper.Map<Applicant>(request);
            Applicant createdApplicant = _applicantRepository.Add(applicant);
            CreatedApplicantResponse response = _mapper.Map<CreatedApplicantResponse>(createdApplicant);
            return response;
        }

        public DeletedApplicantResponse Delete(DeleteApplicantRequest request)
        {
            //Using AutoMapper
            Applicant selectedApplicant = _applicantRepository.Get(sa => sa.Id == request.Id);

            if (selectedApplicant == null)
                throw new Exception("Başvuru sahibi bulunamadı.");

            _mapper.Map(request, selectedApplicant);
            _applicantRepository.Delete(selectedApplicant);
            Applicant deletedApplicant = _applicantRepository.Delete(selectedApplicant);
            DeletedApplicantResponse response = _mapper.Map<DeletedApplicantResponse>(deletedApplicant);
            return response;
        }

        public List<GetListApplicantResponse> GetList()
        {
            //Using AutoMapper
            List<Applicant> instructors = _applicantRepository.GetAll();
            List<GetListApplicantResponse> responses = _mapper.Map<List<GetListApplicantResponse>>(instructors);
            return responses;
        }

        public UpdatedApplicantResponse Update(UpdateApplicantRequest request)
        {
            //Using AutoMapper
            Applicant selectedApplicant = _applicantRepository.Get(sa => sa.Id == request.Id);

            if (selectedApplicant == null)
                throw new Exception("Başvuru sahibi bulunamadı.");

            _mapper.Map(request, selectedApplicant);
            _applicantRepository.Update(selectedApplicant);
            Applicant updatedApplicant = _applicantRepository.Update(selectedApplicant);
            UpdatedApplicantResponse response = _mapper.Map<UpdatedApplicantResponse>(updatedApplicant);
            return response;
        }
    }
}
