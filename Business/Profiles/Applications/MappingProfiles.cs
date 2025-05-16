using AutoMapper;
using Business.Dtos.Request.Applications;
using Business.Dtos.Response.Applications;
using Entities;

namespace Business.Profiles.Applications
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Application, CreateApplicationRequest>().ReverseMap();
            CreateMap<Application, CreatedApplicationResponse>().ReverseMap();
            CreateMap<Application, UpdateApplicationRequest>().ReverseMap();
            CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();
            CreateMap<Application, DeleteApplicationRequest>().ReverseMap();
            CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();
            CreateMap<Application, GetListApplicationRequest>().ReverseMap();
            CreateMap<Application, GetListApplicationResponse>().ReverseMap();
        }
    }
}
