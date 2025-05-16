using Business.Abstracts;
using Business.Dtos.Request.Bootcamps;
using Business.Dtos.Request.Employees;
using Business.Dtos.Response.Bootcamps;
using Business.Dtos.Response.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampsController : ControllerBase
    {
        private readonly IBootcampService _bootcampService;

        public BootcampsController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpPost]
        public ActionResult<CreatedBootcampResponse> Add([FromBody] CreateBootcampRequest request)
        {
            return Created("", _bootcampService.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedBootcampResponse> Update([FromBody] UpdateBootcampRequest request)
        {
            var res = _bootcampService.Update(request);
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult<DeletedBootcampResponse> Delete([FromBody] DeleteBootcampRequest request)
        {
            var res = _bootcampService.Delete(request);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult<List<GetListBootcampResponse>> GetList()
        {
            return Ok(_bootcampService.GetList());
        }
    }
}
