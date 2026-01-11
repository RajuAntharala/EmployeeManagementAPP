
using EmployeeManagementApp.Entities;

namespace EmployeeMangement.Repos.DeportmentRepos
{
    public  interface IDepartmentRepository
    {
      Task<List<Department>> GetAllDepartmentsAsync();

        Task<Department> GetDepartmentByIdAsync(int id);

        Task CreateDepartmentAsync(Department entity);
        Task UpdateDepartmentAsync(Department entity);  // i will get the all data from entity and update it

        
        Task DeleteDepartmentAsync(Task<Department> departmentEntity);
    }
}
