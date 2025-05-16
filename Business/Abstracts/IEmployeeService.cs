using Business.Dtos.Request.Employees;
using Business.Dtos.Response.Employees;

namespace Business.Abstracts
{
    public interface IEmployeeService
    {
        CreatedEmployeeResponse Add(CreateEmployeeRequest request);
        List<GetListEmployeeResponse> GetList();
        UpdatedEmployeeResponse Update(UpdateEmployeeRequest request);
        DeletedEmployeeResponse Delete(DeleteEmployeeRequest request);
    }
}
