using EmployeeDemo.APIs.Entities;
using EmployeeManagementApp.Repos.Data;

using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Repos
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }
    }
}