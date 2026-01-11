

using EmployeeDemo.APIs.Entities;
using EmployeeManagementApp.Entities;
using EmployeeMangement.Repos.DesignationRepos;
using EmpolyeeManagement.DTOs.Department;
using EmpolyeeManagement.DTOs.Designation;
using System.Net.Security;

namespace EmployeeManagement.Services.DesignationService
{
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepository _designationRepository;

        public DesignationService(IDesignationRepository designationRepository)
        {
            _designationRepository = designationRepository;
        }
        public async Task<DesignationResponceDto> CreateDesignationAsync(DesignationResponceDto createdto)
        {
            var designationEntity = new Designation();

            designationEntity.DesignationId = createdto.DesignationId;
            designationEntity.Title = createdto.Title;
            designationEntity.Level = createdto.Level;
            await _designationRepository.CreateDesignationAsync(designationEntity);
            var dto = new DesignationResponceDto
            {

                DesignationId = createdto.DesignationId,
                Title = createdto.Title,
                Level = createdto.Level,

            };
            return dto;

           // throw new NotImplementedException();
        }
        public async Task<bool> DeleteDesignationAsync(int id)
        {
            var DesignationEntity = _designationRepository.GetDesignationsByIdAsync(id);
            if (DesignationEntity == null)
            {
                return false;
            }
            await _designationRepository.DeleteDesignationAsync(await DesignationEntity);
            return true;
            // throw new NotImplementedException();
        }
       
        public async Task<List<DesignationResponceDto>> GetAllDesignationsAsync()
        {
            var DesignationData = await _designationRepository.GetAllDesignationsAsync();

            return DesignationData.Select(d => new DesignationResponceDto
            {
               
                DesignationId = d.DesignationId,
                Level = d.Level,
                Title = d.Title,

            }).ToList();


            //throw new NotImplementedException();
        }

        public async Task<DesignationResponceDto1> GetDesignationByIdAsync(int id)
        {
            var DesignationData = await _designationRepository.GetDesignationsByIdAsync(id);

            DesignationResponceDto1 dto = new DesignationResponceDto1
            {
                DesignationId = DesignationData.DesignationId,
                Level = DesignationData.Level,

            };

            return dto;
           // throw new NotImplementedException();
        }

        public async Task<bool> UpdateDesignationAsync(int id, DesignationUpdateDto updateDto)
        {
            var DesignationEntity = await _designationRepository.GetDesignationsByIdAsync(id);

            if(DesignationEntity == null)
            {
                return false;
            }
            DesignationEntity.Title = updateDto.Title;
            DesignationEntity.Level = updateDto.Level;

            await _designationRepository.UpdateDesignationAsync(DesignationEntity);
            return true;
;            //throw new NotImplementedException();
        }
    }
}
