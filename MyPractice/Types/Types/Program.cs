using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            int a = 10;
            int c;
            //int b = a;//b =10

            //a = 20;//b=10

            ////a =?, b=?

            //Console.WriteLine($"a={a} and b={b}");

            //var emp1 = new Employee { FirstName = "Van", LastName = "Pham", Ages = 31 , Note ="Nothing"};

            //var emp2 = new Employee { FirstName = "Tuan", LastName = "Pham", Ages = 27, Note = "Nothing" };

            //var employees = new List<Employee> { emp1, emp2 };
            //Console.WriteLine("List emps:");
            //PrintEmployees(employees);

            //UpdateEmployee(emp1);

            //Console.WriteLine(emp1.FirstName);
            //Console.WriteLine("List emps after update emp1:");
            //PrintEmployees(employees);

            //emp1.Note = "Old Old";
            //Console.WriteLine("List emps after update emp1:");
            //PrintEmployees(employees);

            //UpdateEmployees(employees);
            //Console.WriteLine("List emps after update:");
            //PrintEmployees(employees);

            //emp1.FirstName=?
            //emp3.FirstName=?

            int d=100;

           // UpdateInteger(d);

            UpdateValueInteger1(out d);
            Console.WriteLine(d.ToString());
            UpdateValueInteger2(ref d);

            //d = Get2X(100);
            // var e = Get2X(d);

            Console.WriteLine(d.ToString());
            //Console.WriteLine(e.ToString());
            Console.ReadKey();
        }

        private static void UpdateInteger( int d)
        {
            d = d * 2;
        }

        private static void UpdateValueInteger1( out int d)
        {
            d = 100;
        }

        private static void UpdateValueInteger2(ref int d)
        {
            d = 1000;
        }

        private static int Get2X(int d)
        {
            d = d * 2;

            return d;
        }

        private static void UpdateEmployee(Employee emp)
        {
            emp.FirstName = "Trump";
        }
        private static void PrintEmployees(List<Employee> emps)
        {
            foreach (var emp in emps)
            {
                Console.WriteLine($"FirstName: {emp.FirstName} LastName:{emp.LastName} Ages:{emp.Ages} Note:{emp.Note}");
            }
        }

        private static void UpdateEmployees(List<Employee> emps)
        {
            foreach (var emp in emps)
            {
                if(emp.Ages> 30)
                {
                    emp.Note = "Old";
                }
            }
        }


    }
}
