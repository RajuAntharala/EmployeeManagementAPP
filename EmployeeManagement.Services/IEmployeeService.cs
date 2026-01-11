

using EmployeeDemo.APIs.Entities;
using EmpolyeeManagement.DTOs.Employee;

namespace EmployeeManagementApp.Services
{
    public interface  IEmployeeService
    {
        Task<List<EmployeeResponseDto>> GetAllEmployeeAsync();

        Task<EmployeeResponseDto1> GetEmployeeByIdAsync(int id);
        Task<EmployeeResponseDto> CreateEmployeeAsync(EmployeeCreateDto createDto);

        Task<bool> UpdateEmployeeAsync(int id, EmployeeUpdateDto updateDto);

        Task<bool> DeleteEmployeeAsync(int id);
    }
} 