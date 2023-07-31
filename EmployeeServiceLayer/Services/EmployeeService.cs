using EmployeeDataAccessLayer.Entities;
using EmployeeDataAccessLayer.IRepositories;
using EmployeeServiceLayer.IServices;
using EmployeeViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }
        public void AddEmployee(EmployeeViewModel employeeViewModel)
        {
            Employee employee = new Employee();

            employee.EmpName = employeeViewModel.EmpName;
            employee.Address = employeeViewModel.Address;
            employee.City = employeeViewModel.City;
            employee.Salary = employeeViewModel.Salary;
            employee.IsActive = true;
            employee.CreatedDate = DateTime.Now;
            employee.CreatedBy = 1;

            employeeRepository.AddEmployee(employee);
        }
    }
}
