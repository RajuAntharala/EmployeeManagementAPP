

using EmployeeManagementApp.Entities;
using EmpolyeeManagement.DTOs.Department;

namespace EmployeeManagement.Services.DepartmentServices
{
    public interface  IDepartmentService
    {
      Task<List<DepartmentResponseDto>> GetAllDepartmentsAsync();
        Task<DepartmentResponseDto1> GetDepartmentByIdAsync(int id);
        Task<DepartmentResponseDto> CreateDepartmentAsync(DepartmentCreateDto createDto);
        Task<bool> UpdateDepartmentAsync(int id, DepartmentUpdateDto updateDto);
        Task<bool> DeleteDepartmentAsync(int id);



    }
}
