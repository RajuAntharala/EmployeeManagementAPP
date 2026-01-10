using EmployeeDemo.APIs.Entities;
using EmployeeManagementApp.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagementApp.Repos.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } 


        public DbSet<Designation> Designations { get; set; }


        public DbSet<Department> Departments { get; set; } 

        public DbSet<Attendance> Attendances { get; set; } 

    }
}