

using EmployeeDemo.APIs.Entities;
using EmployeeManagementApp.Repos;
using EmpolyeeManagement.DTOs.Employee;

namespace EmployeeManagementApp.Services
{
    public class EmployeeService : IEmployeeService

    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeResponseDto>> GetAllEmployeeAsync()
        {
            
          var RawData = await  _employeeRepository.GetAllEmployeeAsync();


            var names = RawData.Select(x => x.Name);

            var mydatasometing = RawData.Select(x => new { EmployeeNames = x.Name,EmployeeEmail = x.Email, EmployeePosition  = x.Position});

           var filterdData = RawData.Select(x => new EmployeeResponseDto
           {
                Id = x.Id,
                EmployeeName = x.Name,
               EmployeeEmail = x.Email,
               EmployeePosition = x.Position


            });
            

            return filterdData.ToList();
            // throw new NotImplementedException();
        }

        public async Task<EmployeeResponseDto1> GetEmployeeByIdAsync(int id)
        {

            var SingleEmployeeRawdata = await _employeeRepository.GetEmployeeByIdAsync(id);




            // one way to present-------------


            //EmployeeResponseDto1 dto = new EmployeeResponseDto1();
            //dto.Id = SingleEmployeeRawdata.Id;
            //dto.EmployeeName = SingleEmployeeRawdata.Name;
            //dto.EmployeeEmail = SingleEmployeeRawdata.Email;



            // antherway -------------------


            EmployeeResponseDto1 dto = new EmployeeResponseDto1()
            {
                Id = SingleEmployeeRawdata.Id,
                EmployeeName = SingleEmployeeRawdata.Name,
                EmployeeEmail = SingleEmployeeRawdata.Email,


            };



            return dto;



            //throw new NotImplementedException();
        }



        public async Task<EmployeeResponseDto> CreateEmployeeAsync(EmployeeCreateDto createDto)
        {

            var entity = new Employee();
            entity.Name = createDto.EmployeeName;
            entity.Email = createDto.EmployeeEmail;
            entity.Position = createDto.EmployeePosition;
            
         await _employeeRepository.CreateEmployeeAsync(entity);
          
            var dto = new EmployeeResponseDto()
            {
                Id = entity.Id,
                EmployeeName = entity.Name,
                EmployeeEmail = entity.Email,
                EmployeePosition = entity.Position
            };
            return dto;
            
           // return await _employeeRepository.CreateEmployeeAsync(createDto);
            //throw new NotImplementedException();
        }

        public async Task<bool> UpdateEmployeeAsync(int id, EmployeeUpdateDto updateDto)
        {
            var EmployeeEntity = await _employeeRepository.GetEmployeeByIdAsync(id);

          if( EmployeeEntity == null)
            {
                return false;
            }
           
            EmployeeEntity.Name = updateDto.EmployeeName;
            EmployeeEntity.Email = updateDto.EmployeeEmail;
            EmployeeEntity.Position = updateDto.EmployeePosition;

            await _employeeRepository.UpdateEmployeeAsync(EmployeeEntity);

            return true;
            // throw new NotImplementedException();

        }

        public async Task<bool> DeleteEmployeeAsync(int id)
        {

            var EmployeeEntity = await _employeeRepository.GetEmployeeByIdAsync(id);

            if (EmployeeEntity == null)
            {
                return false;
            }

            await _employeeRepository.DeleteEmployeeAsync(EmployeeEntity);

            return true;


            //throw new NotImplementedException();
        }
    }
}