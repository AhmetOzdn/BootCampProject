using Business.Abstracts;
using Business.Dtos.Request.Applicant;
using Business.Dtos.Response.Applicant;
using Entities;
using Repositories.Abstacts;
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

        public ApplicantManager(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        public CreatedApplicantResponse Add(CreateApplicantRequest request)
        {
            Applicant applicant = new Applicant
            {

                Id = request.UserId,
                About = request.About
            };

            Applicant addedApplicant = _applicantRepository.Add(applicant);

            return new CreatedApplicantResponse
            {
                Id = addedApplicant.Id,
                CreatedDate = addedApplicant.CreatedDate,
            };
        }

        public void Delete(Guid applicantId)
        {
            throw new NotImplementedException();
        }

        public List<Applicant> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Applicant applicant)
        {
            throw new NotImplementedException();
        }
    }
}
