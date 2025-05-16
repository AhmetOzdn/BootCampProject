using Business.Abstracts;
using Business.Dtos.Request.Users;
using Business.Dtos.Response.Users;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService=userService;
        }

        [HttpPost]
        public ActionResult<CreatedUserResponse> Add([FromBody] CreateUserRequest request)
        {
            return Created("", _userService.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedUserResponse> Update([FromBody] UpdateUserRequest request)
        {
            var res = _userService.Update(request);
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult<DeletedUserResponse> Delete([FromBody] DeleteUserRequest request) {
            var res = _userService.Delete(request);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult<List<GetListUserResponse>> GetList()
        {
            return Ok(_userService.GetList());
        }

      
    }
}
