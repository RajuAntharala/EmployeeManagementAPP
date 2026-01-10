

using EmployeeDemo.APIs.Entities;
using EmpolyeeManagement.DTOs.Employee;

namespace EmployeeManagementApp.Services
{
    public interface  IEmployeeService
    {
        Task<List<EmployeeResponseDto>> GetAllEmployeeAsync();
        
    }
} 