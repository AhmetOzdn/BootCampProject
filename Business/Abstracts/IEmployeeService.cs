using Business.Dtos.Response.Employee;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEmployeeService
    {
        CreatedEmployeeResponse Add(CreatedEmployeeResponse response);
        List<Employee> GetAll();
        void Update(Employee employee);
        void Delete(Guid employeeId);
    }
}
