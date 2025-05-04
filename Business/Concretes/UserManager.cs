using Azure.Core;
using Business.Abstracts;
using Business.Dtos.Request.User;
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
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public CreatedUserResponse Add(CreateUserRequest request)
        {
            User user = new User
            {

                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalIdentity = request.NationalIdentity,
                Email = request.Email,
                DateOfBirth = request.DateOfBirth,
                Password = request.Password,
                UserName = request.UserName,
            };
            User addedUser = _userRepository.Add(user);

            return new CreatedUserResponse
            {
                Id = addedUser.Id,
                UserName = request.UserName,
                FirstName = addedUser.FirstName,
                LastName= addedUser.LastName,
                NationalIdentity= addedUser.NationalIdentity,
                DateOfBirth= addedUser.DateOfBirth,
                Email = addedUser.Email,
                Password= addedUser.Password,
                CreatedDate = addedUser.CreatedDate,
            };
        }


        public List<GetListUserResponse> GetList()
        {
            List<User> users = _userRepository.GetAll();
            List<GetListUserResponse> responses = new List<GetListUserResponse>();

            foreach (var user in users)
            {
                responses.Add(new GetListUserResponse
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    DateOfBirth = user.DateOfBirth,
                    NationalIdentity = user.NationalIdentity,
                    Email = user.Email,
                    Password = user.Password,
                    CreatedDate = user.CreatedDate,
                    UpdatedDate = user.UpdatedDate ?? null,
                    DeletedDate = user.DeletedDate ?? null

                });
            }
            return responses;
        }

        public UpdatedUserResponse Update(UpdateUserRequest request)
        {
            User selectedUser = _userRepository.Get(su => su.Id == request.Id);

            if (selectedUser == null)
                throw new Exception("Kullanıcı Bulunamadı");

            selectedUser.FirstName = request.FirstName;
            selectedUser.LastName = request.LastName;
            selectedUser.Email = request.Email;
            selectedUser.UserName = request.UserName;
            selectedUser.DateOfBirth =  request.DateOfBirth ?? selectedUser.DateOfBirth;
            selectedUser.NationalIdentity = request.NationalIdentity;
            selectedUser.Password = request.Password;

            selectedUser.UpdatedDate = DateTime.Now;
            _userRepository.Update(selectedUser);

            return new UpdatedUserResponse
            {
                Id = selectedUser.Id,
                UpdatedDate = selectedUser.UpdatedDate ?? DateTime.Now,
                Message = "Kullanıcı başarıyla güncellendi"
            };
        }

        public DeletedUserResponse Delete(DeleteUserRequest request)
        {
            User selectedUser = _userRepository.Get(su => su.Id == request.Id);

            if (selectedUser == null)
                throw new Exception("Kullanıcı Bulunamadı");

            selectedUser.DeletedDate = DateTime.Now;
            _userRepository.Update(selectedUser);

            return new DeletedUserResponse
            {
                Id = selectedUser.Id,
                Message = "Kullanıcı başarıyla silindi"
            };
        }
    }
}
