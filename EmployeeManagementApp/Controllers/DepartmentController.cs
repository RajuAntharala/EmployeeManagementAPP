using EmployeeManagement.Services.DepartmentServices;
using EmpolyeeManagement.DTOs.Department;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController: ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }


        [HttpGet("GetAllDepartments")]
        // GET:https://localhost:7189/api/Department/GetAllDepartments
        public async Task<IActionResult> GetAllDepartments()
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            return Ok(departments);
        }

        [HttpGet("GetDepartmentById/{id}")]
        // GET:https://localhost:7189/api/Department/GetDepartmentById/1
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var department = await _departmentService.GetDepartmentByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);


        }

        [HttpPost("CreateDepartment")]
        // POST:https://localhost:7189/api/Department/CreateDepartment
        public async Task<IActionResult> CreateDepartment([FromBody] DepartmentCreateDto departmentCreateDto)
        {
            var createdDepartment = await _departmentService.CreateDepartmentAsync(departmentCreateDto);
            return createdDepartment is null ? BadRequest() : Ok(createdDepartment);
        }

        [HttpPut("UpdateDepartment/{id}")]
        // PUT:https://localhost:7189/api/Department/UpdateDepartment/1
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] DepartmentUpdateDto departmentUpdateDto)
        {
            var updatedDepartment = await _departmentService.UpdateDepartmentAsync(id, departmentUpdateDto);
            return updatedDepartment is false ? NotFound() : Ok(updatedDepartment);
        }

        [HttpDelete("DeleteDepartment/{id}")]
        // DELETE:https://localhost:7189/api/Department/DeleteDepartment/1
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var isDeleted = await _departmentService.DeleteDepartmentAsync(id);
            return isDeleted is false ? Ok() : NotFound();
        }


    }
}
