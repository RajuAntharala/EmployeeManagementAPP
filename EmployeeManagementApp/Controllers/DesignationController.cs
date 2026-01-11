using Microsoft.AspNetCore.Mvc;
using EmployeeManagementApp.Services;
using EmployeeManagement.Services.DesignationService;
using EmpolyeeManagement.DTOs.Designation;

namespace EmployeeManagement.APIs.Controllers
{
    [ApiController]
    [Route("api[controller]")]
    public class DesignationController : ControllerBase
    {
        private readonly IDesignationService _designationService;
        public DesignationController(IDesignationService designationService)
        {
            _designationService = designationService;
        }

        [HttpGet("GetDesignations")]

        // endpont : https://localhost:7189/api/Designation/GetDesignations
        public async Task<IActionResult> GetDesignations()
        {
            var data = await _designationService.GetAllDesignationsAsync();
            return data is null ? NotFound() : Ok(data);
        }

        [HttpGet("GetDesignationBYID")]
        // enspont : https://localhost:7189/api/Designation/GetDesignationBYID
        public async Task<IActionResult> GetDesignationBYID([FromQuery] int Id)
        {
            var data = await _designationService.GetDesignationByIdAsync(Id);
            return data is null ? NotFound() : Ok(data);
        }


        [HttpPost("CreateDesigantion")]
        // endpoint : https://localhost:7189/api/Designation/CreateDesigantion
        public async Task<IActionResult> CreateDesigantion([FromBody] DesignationCreateDto createDto)
        {
            var result = await _designationService.CreateDesignationAsync(createDto);
            return result is null ? NotFound() : Ok(result);
        }


    }
}
