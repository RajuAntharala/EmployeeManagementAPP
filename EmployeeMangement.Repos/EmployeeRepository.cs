using EmployeeDemo.APIs.Entities;
using EmployeeManagementApp.Repos.Data;
using EmpolyeeManagement.DTOs.Employee;
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

        public async Task CreateEmployeeAsync(Employee entity)
        {
           await _dbContext.Employees.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

          //  throw new NotImplementedException();
        }

        public async Task DeleteEmployeeAsync(Employee entity)
        {
             _dbContext.Employees.Remove(entity);

            await _dbContext.SaveChangesAsync();

           // throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int Id)
        {
            return await _dbContext.Employees.FindAsync(Id);

           // return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == Id);
            //throw new NotImplementedException();
        }

        public async Task UpdateEmployeeAsync(Employee entity)
        {
                  _dbContext.Employees.Update(entity);
            await _dbContext.SaveChangesAsync();



            //throw new NotImplementedException();
        }
    }
}