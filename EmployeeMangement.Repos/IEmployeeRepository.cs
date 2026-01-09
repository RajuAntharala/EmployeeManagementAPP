using EmployeeDemo.APIs.Entities;


namespace EmployeeManagementApp.Repos
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeeAsync();

    }
}