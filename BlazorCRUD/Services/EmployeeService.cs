using BlazorCRUD.Domain;
using BlazorCRUD.DomainObjects;
using BlazorCRUD.Services.Helpers;
using BlazorCRUD.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly EmployeeLogic _db;

        public EmployeeService(EmployeeLogic db)
        {
            _db = db;
        }

        public List<EmployeeVM> GetEmployees() => _db.GetEmployees().Map();

        public string Create(Employee objEmployee)
        {
            _db.CreateNewEmployee(objEmployee);
            return "Save Succefully";
        }

        public EmployeeVM GetEmployeeById(int id) => _db.GetEmployee(id).Map();

        public string UpdateEmployee(Employee objEmployee)
        {
            _db.UpdateEmployee(objEmployee);
            return "Update Successfully";
        }

        public string DeleteEmpInfo(Employee objEmployee)
        {
            _db.DeleteEmployee(objEmployee.EmployeeId);
            return "Delete Successfully";
        }
    }
}
