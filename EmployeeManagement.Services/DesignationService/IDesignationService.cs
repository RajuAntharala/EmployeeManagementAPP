

using EmployeeManagementApp.Entities;
using EmpolyeeManagement.DTOs.Designation;

namespace EmployeeManagement.Services.DesignationService
{
    public interface IDesignationService
    {
        Task<List<DesignationResponceDto>> GetAllDesignationsAsync();
        Task<DesignationResponceDto1> GetDesignationByIdAsync(int id);

        Task<DesignationResponceDto> CreateDesignationAsync(DesignationCreateDto createDto);

        Task<bool> UpdateDesignationAsync(int id, DesignationUpdateDto updateDto);

        Task<bool> DeleteDesignationAsync(int id);
        //Task CreateDesignationAsync(DesignationCreateDto createDto);
    }
}
