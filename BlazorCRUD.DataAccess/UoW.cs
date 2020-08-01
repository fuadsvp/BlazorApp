using BlazorCRUD.DataAccess.Repo;
using BlazorCRUD.DomainObjects;
using System.Collections.Generic;

namespace BlazorCRUD.DataAccess
{
    public class UoW
    {
        EmployeeRepository Employee;
        public UoW(EmployeeRepository employeeRepository)
        {
            Employee = employeeRepository;
        }

        public List<Employee> GetEmployees()
        {
            return Employee.GetEmployees();
        }

        public Employee GetEmployee(int key)
        {
            return Employee.GetEmployee(key);
        }

        public void CreateNewEmployee(Employee employee)
        {
            try
            {
                bool isEmployeeAlreadyExists = !(Employee.GetEmployee(employee.Id) is null);
                if (isEmployeeAlreadyExists)
                    throw new System.Exception("You cannot create already existing employee");

                Employee.AddEmployee(employee);
                Employee.TransactionComplete();
            }
            catch (System.Exception)
            {
                Employee.TransactionRollback();
                throw;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                bool isEmployeeAlreadyExists = !(Employee.GetEmployee(employee.Id) is null);
                if (!isEmployeeAlreadyExists)
                    throw new System.Exception("You cannot update non-existing employee");

                Employee.UpdateEmployee(employee);
                Employee.TransactionComplete();
            }
            catch (System.Exception)
            {
                Employee.TransactionRollback();
                throw;
            }
        }

        public void DeleteEmployee(int key)
        {
            var employeeToDelete = Employee.GetEmployee(key);
            bool isEmployeeAlreadyExists = !(employeeToDelete is null);
            if (!isEmployeeAlreadyExists)
                throw new System.Exception("You cannot delete non-existing employee");
            DeleteEmployee(employeeToDelete);
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                Employee.DeleteEmployee(employee);
                Employee.TransactionComplete();
            }
            catch (System.Exception)
            {
                Employee.TransactionRollback();
                throw;
            }
        }
    }
}
