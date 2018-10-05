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
                new Employee() {FirstName = "Van", LastName = "Pham", Address = "Thai Nguyen", Age = 30, Gender = "Men"},
                new Employee() {FirstName = "Tuan Anh", LastName = "Pham", Address = "Nam Dinh"},
                new Employee() {FirstName = "Hieu", LastName = "Nguyen", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Duc Anh", LastName = "Hoang", Address = "Ninh Binh"},
                new Employee() {FirstName = "Son", LastName = "Nguyen", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Le", LastName = "Phan", Address = "Nam Dinh"},
                new Employee() {FirstName = "Hoang", LastName = "Nguyen", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Dieu Anh", LastName = "Nguyen", Address = "Ninh Binh"},
                new Employee() {FirstName = "Kien", LastName = "Dinh", Address = "Thai Nguyen"},
                new Employee() {FirstName = "Linh", LastName = "Hoang", Address = "Nam Dinh"}
            };
            
            return employees;
        }
    }
}
