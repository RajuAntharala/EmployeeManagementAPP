

namespace EmployeeManagementApp.Entities
{

    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } // Present / Absent
    }

}