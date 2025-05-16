using Business.Abstracts;
using Business.Dtos.Request.Instructors;
using Business.Dtos.Response.Instructors;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpPost]
        public ActionResult<CreatedInstructorResponse> Add([FromBody] CreateInstructorRequest request)
        {
            return Created("", _instructorService.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedInstructorResponse> Update([FromBody] UpdateInstructorRequest request)
        {
            var res = _instructorService.Update(request);
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult<DeletedInstructorResponse> Delete([FromBody] DeleteInstructorRequest request)
        {
            var res = _instructorService.Delete(request);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult<List<GetListInstructorResponse>> GetList()
        {
            return Ok(_instructorService.GetList());
        }
    }
}
