using System.Collections.Generic;
using EmployeeManagerApplication.Models;

namespace EmployeeManagerApplication.Business
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee() {FirstName = "Van", LastName = "Pham", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Tuan Anh", LastName = "Pham", Address = "Nam Dinh"},
                new Employee() {FirstName = "Hieu", LastName = "Nguyen", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Duc Anh", LastName = "Hoang", Address = "Ninh Binh"},
                new Employee() {FirstName = "Son", LastName = "Nguyen", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Le", LastName = "Phan", Address = "Nam Dinh"}
            };
            
            return employees;
        }
    }
}
