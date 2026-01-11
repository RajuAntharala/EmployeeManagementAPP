

using EmployeeManagementApp.Entities;

namespace EmployeeMangement.Repos.DesignationRepos
{
    public interface IDesignationRepository
    {
        Task<List<Designation>> GetAllDesignationsAsync();

        Task<Designation> GetDesignationsByIdAsync(int id);

        Task CreateDesignationAsync(Designation entity);
        Task UpdateDesignationAsync(Designation entity);
        Task DeleteDesignationAsync(Designation designation);
       // Task DeleteDesignationAsync(Task<Designation> designationEntity);
    }
}
