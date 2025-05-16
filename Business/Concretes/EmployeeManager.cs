using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request.Employees;
using Business.Dtos.Response.Employees;
using Business.Dtos.Response.Instructors;
using Entities;
using Repositories.Abstacts;
using Repositories.Concretes;

namespace Business.Concretes
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeManager(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public CreatedEmployeeResponse Add(CreateEmployeeRequest request)
        {
            //Employee employee = new Employee
            //{
            //    UserName = request.UserName,
            //    FirstName = request.FirstName,
            //    LastName = request.LastName,
            //    Password = request.Password,
            //    Email = request.Email,
            //    NationalIdentity = request.NationalIdentity,
            //    DateOfBirth = request.DateOfBirth,
            //    Position = request.Position,
            //};

            //Employee addedEmployee = _employeeRepository.Add(employee);

            //return new CreatedEmployeeResponse
            //{
            //    Id = addedEmployee.Id,
            //    Position = addedEmployee.Position,
            //    CreatedDate = addedEmployee.CreatedDate,
            //};

            //Using AutoMapper
            Employee employee = _mapper.Map<Employee>(request);
            Employee createdEmployee = _employeeRepository.Add(employee);
            CreatedEmployeeResponse response = _mapper.Map<CreatedEmployeeResponse>(createdEmployee);
            return response;
        }

        public List<GetListEmployeeResponse> GetList()
        {
            //List<Employee> employees = _employeeRepository.GetAll();
            //List<GetListEmployeeResponse> responses = new List<GetListEmployeeResponse>();

            //foreach (var employee in employees)
            //{
            //    responses.Add(new GetListEmployeeResponse
            //    {
            //        Id = employee.Id,
            //        UserName = employee.UserName,
            //        FirstName = employee.FirstName,
            //        LastName = employee.LastName,
            //        Email = employee.Email,
            //        Password = employee.Password,
            //        Position = employee.Position,
            //        CreatedDate = employee.CreatedDate,
            //        UpdatedDate = employee.UpdatedDate ?? null,
            //        DeletedDate = employee.DeletedDate ?? null
            //    });
            //}

            //return responses;

            //Using AutoMapper
            List<Employee> employees = _employeeRepository.GetAll();
            List<GetListEmployeeResponse> responses = _mapper.Map<List<GetListEmployeeResponse>>(employees);
            return responses;
        }


        public DeletedEmployeeResponse Delete(DeleteEmployeeRequest request)
        {
            //Employee selectedEmployee = _employeeRepository.Get(se => se.Id == request.Id);
            //if (selectedEmployee == null)
            //{
            //    throw new Exception("Çalışan Bulunamadı");
            //}

            //selectedEmployee.DeletedDate = DateTime.Now;
            //_employeeRepository.Delete(selectedEmployee);

            //return new DeletedEmployeeResponse
            //{
            //    Id = request.Id,
            //    Message = "Çalışan başarıyla silindi"
            //};

            //Using AutoMapper
            Employee selectedEmployee = _employeeRepository.Get(se => se.Id == request.Id);

            if (selectedEmployee == null)
                throw new Exception("Çalışan Bulunamadı");

            _mapper.Map(request, selectedEmployee);
            _employeeRepository.Delete(selectedEmployee);
            Employee DeletedEmployee = _employeeRepository.Delete(selectedEmployee);
            DeletedEmployeeResponse response = _mapper.Map<DeletedEmployeeResponse>(DeletedEmployee);
            return response;

        }


        public UpdatedEmployeeResponse Update(UpdateEmployeeRequest request)
        {
            //Employee selectedEmployee = _employeeRepository.Get(se => se.Id == request.Id);

            //if (selectedEmployee == null)
            //{
            //    throw new Exception("Çalışan Bulunamadı");
            //}

            //selectedEmployee.UpdatedDate = DateTime.Now;
            //_employeeRepository.Update(selectedEmployee);

            //return new UpdatedEmployeeResponse
            //{
            //    Id = request.Id,
            //    Position = request.Position,
            //    UpdatedDate = DateTime.Now
            //};

            //Using AutoMapper
            Employee selectedEmployee = _employeeRepository.Get(se => se.Id == request.Id);

            if (selectedEmployee == null)
                throw new Exception("Çalışan Bulunamadı");

            _mapper.Map(request, selectedEmployee);
            _employeeRepository.Update(selectedEmployee);
            Employee UpdatedEmployee = _employeeRepository.Update(selectedEmployee);
            UpdatedEmployeeResponse response = _mapper.Map<UpdatedEmployeeResponse>(UpdatedEmployee);
            return response;
        }


    }
}
