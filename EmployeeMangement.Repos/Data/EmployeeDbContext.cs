using EmployeeDemo.APIs.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagementApp.Repos.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = null!;
    }
}