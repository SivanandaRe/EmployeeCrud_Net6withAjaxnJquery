using EmployeeDataAccessLayer.Entities;
using EmployeeViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceLayer.IServices
{
    public interface IEmployeeService
    {
        void AddEmployee(EmployeeViewModel employee);
    }
}
