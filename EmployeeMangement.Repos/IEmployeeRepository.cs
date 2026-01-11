using EmployeeDemo.APIs.Entities;
using EmpolyeeManagement.DTOs.Employee;


namespace EmployeeManagementApp.Repos
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeeAsync();

        Task<Employee> GetEmployeeByIdAsync(int id);

        Task CreateEmployeeAsync(Employee entity);

        Task UpdateEmployeeAsync(Employee entity);  // i will get the all data from entity and update it

        Task DeleteEmployeeAsync(Employee entity);

    }
}