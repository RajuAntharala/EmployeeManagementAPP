

using EmployeeDemo.APIs.Entities;
using EmployeeManagementApp.Repos;
using EmpolyeeManagement.DTOs.Employee;

namespace EmployeeManagementApp.Services
{
    public class EmployeeService : IEmployeeService

    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeResponseDto>> GetAllEmployeeAsync()
        {
            
          var RawData = await  _employeeRepository.GetAllEmployeeAsync();


            var names = RawData.Select(x => x.Name);

            var mydatasometing = RawData.Select(x => new { EmployeeNames = x.Name,EmployeeEmail = x.Email, EmployeePosition  = x.Position});

           var filterdData = RawData.Select(x => new EmployeeResponseDto
           {
                Id = x.Id,
                EmployeeName = x.Name,
               EmployeeEmail = x.Email,
               EmployeePosition = x.Position


            });
            

            return filterdData.ToList();
            // throw new NotImplementedException();
        }

       
    }
}