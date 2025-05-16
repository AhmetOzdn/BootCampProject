using Business.Abstracts;
using Business.Dtos.Request.Applicants;
using Business.Dtos.Request.BlackLists;
using Business.Dtos.Response.Applicants;
using Business.Dtos.Response.BlackLists;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly IApplicantService _applicantService;

        public ApplicantsController(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        [HttpPost]
        public ActionResult<CreatedApplicantResponse> Add([FromBody] CreateApplicantRequest request)
        {
            return Created("", _applicantService.Add(request));
        }

        [HttpPut]
        public ActionResult<UpdatedApplicantResponse> Update([FromBody] UpdateApplicantRequest request)
        {
            var res = _applicantService.Update(request);
            return Ok(res);
        }

        [HttpDelete]
        public ActionResult<DeletedApplicantResponse> Delete([FromBody] DeleteApplicantRequest request)
        {
            var res = _applicantService.Delete(request);
            return Ok(res);
        }

        [HttpGet]
        public ActionResult<List<GetListApplicantResponse>> GetList()
        {
            return Ok(_applicantService.GetList());
        }
    }
}
