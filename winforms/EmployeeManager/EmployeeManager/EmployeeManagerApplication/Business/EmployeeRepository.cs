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
                new Employee() {FirstName = "Tuan Anh", LastName = "Pham", Address = "Nam Dinh", Age = 31, Gender = "Men"},
                new Employee() {FirstName = "Hieu", LastName = "Nguyen", Address = "Thai Nguyen", Age = 32, Gender = "Men"},
                new Employee() {FirstName = "Duc Anh", LastName = "Hoang", Address = "Ninh Binh", Age = 33, Gender = "Men"},
                new Employee() {FirstName = "Son", LastName = "Nguyen", Address = "Thai Nguyen", Age = 34, Gender = "Men"},
                new Employee() {FirstName = "Le", LastName = "Phan", Address = "Nam Dinh", Age = 35, Gender = "Men"},
                new Employee() {FirstName = "Hoang", LastName = "Nguyen", Address = "Thai Nguyen", Age = 36, Gender = "Men"},
                new Employee() {FirstName = "Dieu Anh", LastName = "Nguyen", Address = "Ninh Binh", Age = 37, Gender = "Women"},
                new Employee() {FirstName = "Kien", LastName = "Dinh", Address = "Thai Nguyen", Age = 38, Gender = "Men"},
                new Employee() {FirstName = "Linh", LastName = "Hoang", Address = "Nam Dinh", Age = 39, Gender = "Women"}
            };
            
            return employees;
        }
    }
}
