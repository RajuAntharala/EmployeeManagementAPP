

using EmployeeManagementApp.Entities;
using EmployeeManagementApp.Repos.Data;
using EmpolyeeManagement.DTOs.Employee;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangement.Repos.DesignationRepos
{
    public class DesignationRepository : IDesignationRepository
    {
        private readonly EmployeeDbContext _dbContext;

        public DesignationRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateDesignationAsync(Designation entity)
        {
            await _dbContext.Designations.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            //throw new NotImplementedException();
        }

        public async Task DeleteDesignationAsync(Designation designation)
        {

            _dbContext.Designations.Remove(designation);
            await _dbContext.SaveChangesAsync();
           // throw new NotImplementedException();
        }

        //public Task DeleteDesignationAsync(Task<Designation> designationEntity)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<Designation>> GetAllDesignationsAsync()
        {

           return await _dbContext.Designations.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<Designation> GetDesignationsByIdAsync(int id)
        {

            return await _dbContext.Designations.FindAsync(id);
            //throw new NotImplementedException();
        }

        public async Task UpdateDesignationAsync(Designation entity)
        {
            _dbContext.Designations.Update(entity);
            await _dbContext.SaveChangesAsync();
            //throw new NotImplementedException();
        }
    }
}
