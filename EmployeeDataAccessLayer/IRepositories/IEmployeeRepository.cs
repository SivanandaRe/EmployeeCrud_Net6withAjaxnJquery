using EmployeeDataAccessLayer.Entities;

namespace EmployeeDataAccessLayer.IRepositories
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
    }
}
