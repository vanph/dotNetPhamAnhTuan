using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //object - instance
            //var emp1 = new Employee {FirstName = "Van", LastName = "Pham", Address = "Thai Nguyen"};
            /*
            var emp = new Employee();
            emp.FirstName = "Anh Tuan";
            emp.LastName = "Pham";
            emp.Address = "Nam Dinh"; */

            var emp = new Employee
            {
                FirstName = "Anh Tuan",
                LastName = "Pham",
                Address = "Nam Dinh"
            };

            emp.Work();


            var emp2 = new Employee { FirstName = "Van", LastName = "Pham", Address = "Thai Nguyen" };

            var employeeList = new List<Employee>();
            employeeList.Add(emp);
            employeeList.Add(emp2);

            foreach (var employee in employeeList)
            {
                Console.WriteLine($"FirstName: {employee.FirstName} - LastName: {employee.LastName} - Address {employee.Address}" );
            }

            Console.ReadLine();
        }
    }
}
