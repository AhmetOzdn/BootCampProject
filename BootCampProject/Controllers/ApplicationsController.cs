using Business.Abstracts;
using Business.Dtos.Request.Applications;
using Business.Dtos.Request.BlackLists;
using Business.Dtos.Response.Applications;
using Business.Dtos.Response.BlackLists;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost]
        public ActionResult<CreatedApplicationResponse> Add([FromBody] CreateApplicationRequest request)
        {
            return Created("", _applicationService.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedApplicationResponse> Update([FromBody] UpdateApplicationRequest request)
        {
            var res = _applicationService.Update(request);
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult<DeletedApplicationResponse> Delete([FromBody] DeleteApplicationRequest request)
        {
            var res = _applicationService.Delete(request);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult<List<GetListApplicationResponse>> GetList()
        {
            return Ok(_applicationService.GetList());
        }
    }
}
