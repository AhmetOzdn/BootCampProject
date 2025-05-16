using Business.Dtos.Request.Users;
using Business.Dtos.Response.Users;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        CreatedUserResponse Add(CreateUserRequest request);
        List<GetListUserResponse> GetList();
        UpdatedUserResponse Update(UpdateUserRequest user);
        DeletedUserResponse Delete(DeleteUserRequest userId);
    }
}
