

using EmployeeManagementApp.Entities;
using EmployeeManagementApp.Repos.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangement.Repos.DeportmentRepos
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _dbcontext;
        public DepartmentRepository(EmployeeDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task CreateDepartmentAsync(Department entity)
        {
            await _dbcontext.Departments.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            
           // throw new NotImplementedException();
        }

     
        public async Task DeleteDepartmentAsync(Task<Department> departmentEntity)
        {

            var entity = await departmentEntity;
            _dbcontext.Departments.Remove(entity);
            await _dbcontext.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {

            return await _dbcontext.Departments.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<Department> GetDepartmentByIdAsync(int id)
        {
            return await _dbcontext.Departments.FindAsync(id);
           // throw new NotImplementedException();
        }

        public async Task UpdateDepartmentAsync(Department entity)
        {

            _dbcontext.Departments.Update(entity);
            await _dbcontext.SaveChangesAsync();

           // throw new NotImplementedException();
        }
    }
}
