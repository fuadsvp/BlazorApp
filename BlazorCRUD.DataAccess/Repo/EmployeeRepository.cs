using BlazorCRUD.DomainObjects;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.DataAccess.Repo
{
    public class EmployeeRepository
    {
        private readonly AppDB AppDB;
        public EmployeeRepository(AppDB database)
        {
            AppDB = database;
        }

        public List<Employee> GetEmployees()
        {
            return AppDB.Employees.ToList();
        }

        public Employee GetEmployee(int key)
        {
            return AppDB.Employees.Find(key);
        }

        public void AddEmployee(Employee employee)
        {
            AppDB.Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            AppDB.Employees.Update(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            AppDB.Employees.Remove(employee);
        }

        public void TransactionComplete()
        {
            AppDB.SaveChanges();
        }

        public void TransactionRollback()
        {
            AppDB.Dispose();
        }
    }
}
