using EmployeeDataAccessLayer.Entities;
using EmployeeDataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccessLayer.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext employeeDbContext;

        public EmployeeRepository(EmployeeDbContext _employeeDbContext)
        {
            employeeDbContext = _employeeDbContext;
        }

        public void AddEmployee(Employee employee)
        {
            employeeDbContext.Add(employee);
            employeeDbContext.SaveChanges();
        }
    }
}
