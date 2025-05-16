using Business.Abstracts;
using Business.Dtos.Request.Employees;
using Business.Dtos.Response.Employees;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public ActionResult<CreatedEmployeeResponse> Add([FromBody] CreateEmployeeRequest request)
    {
        return Created("", _employeeService.Add(request));
    }

    [HttpPut]
    public ActionResult<UpdatedEmployeeResponse> Update([FromBody] UpdateEmployeeRequest request)
    {
        var res = _employeeService.Update(request);
        return Ok(res);
    }

    [HttpDelete]
    public ActionResult<DeletedEmployeeResponse> Delete([FromBody] DeleteEmployeeRequest request)
    {
        var res = _employeeService.Delete(request);
        return Ok(res);
    }

    [HttpGet]
    public ActionResult<List<GetListEmployeeResponse>> GetList()
    {
        return Ok(_employeeService.GetList());
    }
}
