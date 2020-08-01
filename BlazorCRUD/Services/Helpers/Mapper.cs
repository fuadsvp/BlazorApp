using BlazorCRUD.DomainObjects;
using BlazorCRUD.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCRUD.Services.Helpers
{
    public static class Mapper
    {
        public static List<EmployeeVM> Map(this List<Employee> employees)
            => employees.Select(Map).ToList();

        public static EmployeeVM Map(this Employee employee)
            =>
               new EmployeeVM
               {
                   EmployeeId = employee.EmployeeId,
                   City = employee.City,
                   Country = employee.Country,
                   Gender = employee.Gender,
                   Name = employee.Name
               };
    }
}
