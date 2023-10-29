using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace class_09_prctc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = default!;
        public string    EmployeeStatus { get; set; } = default!;
        public decimal Salary { get; set; }
        public string PayBasis { get; set; } = default!;
        public string PositionTitle { get; set; } = default!;
    }
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> Options) :base(Options) { }
        public DbSet<Employee> Employees { get; set;}
    }
}
