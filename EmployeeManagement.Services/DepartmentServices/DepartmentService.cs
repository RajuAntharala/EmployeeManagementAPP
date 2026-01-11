using EmployeeManagementApp.Entities;
using EmployeeMangement.Repos.DeportmentRepos;
using EmpolyeeManagement.DTOs.Department;


namespace EmployeeManagement.Services.DepartmentServices
{
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository _Drepo;
        public DepartmentService(IDepartmentRepository Drepo)
        {
            _Drepo = Drepo;
        }

        public async Task<DepartmentResponseDto> CreateDepartmentAsync(DepartmentCreateDto createDto)
        {
            var departmentEntity = new Department();

            departmentEntity.DepartmentId = createDto.Id;
            departmentEntity.DepartmentName = createDto.DepartmentName;
            departmentEntity.Location = createDto.Location;

            await _Drepo.CreateDepartmentAsync(departmentEntity);
            var dto = new DepartmentResponseDto
            {
                DepartmentId = departmentEntity.DepartmentId,
                DepartmentName = departmentEntity.DepartmentName,
                Location = departmentEntity.Location
            };

            return dto;

            
           // throw new NotImplementedException();
        }

        public async Task<bool> DeleteDepartmentAsync(int id)
        {


            var DepartmentEntity = _Drepo.GetDepartmentByIdAsync(id);

            if (DepartmentEntity == null)
            {
                return false;
            }
            await _Drepo.DeleteDepartmentAsync(DepartmentEntity);

            return true;

        }

        public async Task<List<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {

            var departments = await _Drepo.GetAllDepartmentsAsync();

            return departments.Select(d => new DepartmentResponseDto
            {
                DepartmentId = d.DepartmentId,
                DepartmentName = d.DepartmentName,
                Location = d.Location
            }).ToList();




            //throw new NotImplementedException();
        }

        public async Task<DepartmentResponseDto1> GetDepartmentByIdAsync(int id)
        {
            var departmentdata = await _Drepo.GetDepartmentByIdAsync(id);

            //if (departmentdata == null)
            //    throw new Exception("Department not found");

            DepartmentResponseDto1 dto = new DepartmentResponseDto1
            {
                DepartmentId = departmentdata.DepartmentId,
                DepartmentName = departmentdata.DepartmentName,
                
            };

            return dto;
        }

        public async Task<bool> UpdateDepartmentAsync(int id, DepartmentUpdateDto updateDto)
        {
            var departmentEntity = await _Drepo.GetDepartmentByIdAsync(id);
            if (departmentEntity == null)
            {
                return false;
            }
            
             departmentEntity.DepartmentName = updateDto.DepartmentName;
             departmentEntity.Location = updateDto.Location;

            await _Drepo.UpdateDepartmentAsync(departmentEntity);
            return true;
               
               
       
          
            //throw new NotImplementedException();
        }
    }
}
