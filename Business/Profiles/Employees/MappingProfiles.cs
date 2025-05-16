using AutoMapper;
using Business.Dtos.Request.Employees;
using Business.Dtos.Response.Employees;
using Entities;

namespace Business.Profiles.Employees
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, CreateEmployeeRequest>().ReverseMap();
            CreateMap<Employee, CreatedEmployeeResponse>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeRequest>().ReverseMap();
            CreateMap<Employee, UpdatedEmployeeResponse>().ReverseMap();
            CreateMap<Employee, DeleteEmployeeRequest>().ReverseMap();
            CreateMap<Employee, DeletedEmployeeResponse>().ReverseMap();
            CreateMap<Employee, GetListEmployeeRequest>().ReverseMap();
            CreateMap<Employee, GetListEmployeeResponse>().ReverseMap();
        }
    }

}
