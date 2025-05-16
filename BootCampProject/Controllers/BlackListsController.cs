using Business.Abstracts;
using Business.Dtos.Request.BlackLists;
using Business.Dtos.Request.Bootcamps;
using Business.Dtos.Response.BlackLists;
using Business.Dtos.Response.Bootcamps;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlackListsController : ControllerBase
    {
        private readonly IBlackListService _blackListService;

        public BlackListsController(IBlackListService blackListService)
        {
            _blackListService = blackListService;
        }

        [HttpPost]
        public ActionResult<CreatedBlackListResponse> Add([FromBody] CreateBlackListRequest request)
        {
            return Created("", _blackListService.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedBlackListResponse> Update([FromBody] UpdateBlackListRequest request)
        {
            var res = _blackListService.Update(request);
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult<DeletedBlackListResponse> Delete([FromBody] DeleteBlackListRequest request)
        {
            var res = _blackListService.Delete(request);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult<List<GetListBlackListResponse>> GetList()
        {
            return Ok(_blackListService.GetList());
        }
    }
}
