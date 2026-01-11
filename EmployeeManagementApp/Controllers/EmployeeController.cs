using EmployeeManagementApp.Repos;
using EmployeeManagementApp.Services;
using EmpolyeeManagement.DTOs.Employee;
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




        // let prepare the endpoint to get the empolyee by id 
        [HttpGet("GetEmployeeById")]

        // end point : https://localhost:7189/api/Employee/GetEmployeeById
        public async Task<IActionResult> GetEmployeeById([FromQuery] int Id)
        {
            var data = await _employeeService.GetEmployeeByIdAsync(Id);
            return data is null ? NotFound() : Ok(data);

        }


        [HttpPost("CreateEmployee")]

        // end point : https://localhost:7189/api/Employee/CreateEmployee
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeCreateDto createdto )
        {

           var result = await _employeeService.CreateEmployeeAsync(createdto);

            return result is null ? BadRequest() : Ok(result);

        }

        [HttpPut("UpdateEmployee")]
        // end point : https://localhost:7189/api/Employee/UpdateEmployee

        public async Task<IActionResult> UpdateEmployee([FromQuery] int Id, [FromBody] EmployeeUpdateDto updatedto)
        {
            var result = await _employeeService.UpdateEmployeeAsync(Id, updatedto);

            return result is false ? BadRequest() : Ok(result);

        }



        [HttpDelete("DeleteEmployee")]
        // end point : https://localhost:7189/api/Employee/DeleteEmployee

        public async Task<IActionResult> DeleteEmployee([FromQuery] int Id)
        {
            var result = await _employeeService.DeleteEmployeeAsync(Id);
            return result is false ? BadRequest() : Ok(result);

        }



    }
}
 