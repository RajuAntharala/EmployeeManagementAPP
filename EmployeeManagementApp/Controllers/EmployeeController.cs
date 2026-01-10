using EmployeeManagementApp.Repos;
using EmployeeManagementApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeManagement.APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
      private readonly IEmployeeService _employeeService;

       public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetEmployees")]

        //  endpoint: https://localhost:7189/api/Employee/GetEmployees
        public async Task<IActionResult> GetEmployees()
        {
           var data  = await _employeeService.GetAllEmployeeAsync();
            return data is null ? NotFound() : Ok(data);

        }



    }
}
