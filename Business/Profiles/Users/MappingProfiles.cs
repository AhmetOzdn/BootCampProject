using AutoMapper;
using Business.Dtos.Request.Users;
using Business.Dtos.Response.Users;
using Entities;

namespace Business.Profiles.Users
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, CreateUserRequest>().ReverseMap();                
            CreateMap<User, CreatedUserResponse>().ReverseMap();
            CreateMap<User, UpdateUserRequest>().ReverseMap();
            CreateMap<User, UpdatedUserResponse>().ReverseMap();
            CreateMap<User, DeleteUserRequest>().ReverseMap();
            CreateMap<User, DeletedUserResponse>().ReverseMap();
            CreateMap<User, GetListUserRequest>().ReverseMap();
            CreateMap<User, GetListUserResponse>().ReverseMap();
        }
    }
}
