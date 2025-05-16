using AutoMapper;
using Business.Dtos.Request.Applicants;
using Business.Dtos.Response.Applicants;
using Entities;

namespace Business.Profiles.Applicants
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {
            CreateMap<Applicant, CreateApplicantRequest>().ReverseMap();
            CreateMap<Applicant, CreatedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, UpdateApplicantRequest>().ReverseMap();
            CreateMap<Applicant, UpdatedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, DeleteApplicantRequest>().ReverseMap();
            CreateMap<Applicant, UpdatedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, GetListApplicantRequest>().ReverseMap();
            CreateMap<Applicant, GetListApplicantResponse>().ReverseMap();
        }
    }
}
