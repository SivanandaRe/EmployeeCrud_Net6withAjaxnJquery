using EmployeeDataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDataAccessLayer
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
             : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
