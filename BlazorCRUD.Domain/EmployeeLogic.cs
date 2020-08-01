using BlazorCRUD.DataAccess;
using BlazorCRUD.DomainObjects;
using System.Collections.Generic;

namespace BlazorCRUD.Domain
{
    public class EmployeeLogic
    {
        UoW DataAccessWrapper;
        public EmployeeLogic(UoW unitOfWork)
        {
            DataAccessWrapper = unitOfWork;
        }

        public List<Employee> GetEmployees()
        {
            return DataAccessWrapper.GetEmployees();
        }

        public Employee GetEmployee(int key)
        {
            return DataAccessWrapper.GetEmployee(key);
        }

        public void CreateNewEmployee(Employee employee)
        {
            DataAccessWrapper.CreateNewEmployee(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            DataAccessWrapper.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int key)
        {
            DataAccessWrapper.DeleteEmployee(key);
        }
    }
}
