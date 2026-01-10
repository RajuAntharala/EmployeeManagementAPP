

namespace EmpolyeeManagement.DTOs.Employee
{
    public class EmployeeUpdateDto
    {
        public int Id { get; set; }   // Required to update
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
    }
}
