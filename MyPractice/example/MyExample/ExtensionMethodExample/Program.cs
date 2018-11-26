using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();

            var myName = "Van";
            myName.SayHello();
            Console.WriteLine(myName.WordCount());
            
            var t = "tuan";
            t.SayHello();

            var number = 6;
            Console.WriteLine(number.AddMore(7));

            var sentence = "my name is van. How old are you?";
            Console.WriteLine(sentence.WordCount());

            int[] ints = null;
            PrintArrayInOrder(ints);

            Console.WriteLine("PrintListEmployeeInOrder:");
            var employees = new List<Employee>
            {
                new Employee() {FirstName = "Van", LastName = "Pham"},
                new Employee() {FirstName = "Tuan Anh", LastName = "Pham"},
                new Employee() {FirstName = "Hieu", LastName = "Nguyen"},
                new Employee() {FirstName = "Duc Anh", LastName = "Hoang"},
                new Employee() {FirstName = "Son", LastName = "Nguyen"},
                new Employee() {FirstName = "Le", LastName = "Phan"},
                new Employee() {FirstName = "Hoang", LastName = "Nguyen"},
                new Employee() {FirstName = "Dieu Anh", LastName = "Nguyen"},
                new Employee() {FirstName = "Kien", LastName = "Dinh"},
                new Employee() {FirstName = "Linh", LastName = "Hoang"},
                new Employee() {FirstName = "Dieu Anh 2", LastName = "Nguyen"},
                new Employee() {FirstName = "Kien 2", LastName = "Dinh"},
                new Employee() {FirstName = "Linh 2", LastName = "Hoang"}
            };

            PrintListEmployeeInOrder(employees);

            Console.ReadLine();
        }


        private static void Example1()
        {
            int[] ints = {10, 45, 15, 39, 21, 26};

            PrintArrayInOrder(ints);
        }

        private static void PrintArrayInOrder(int[] ints)
        {
            if (!ints.IsNullOrEmpty())
            {
                var result = ints.OrderBy(g => g);

                foreach (var i in result)
                {
                    System.Console.Write(i + " ");
                }
            }
        }

        private static void PrintListEmployeeInOrder(List<Employee> employees)
        {
            if (!employees.IsNullOrEmpty())
            {
                var result = employees.OrderBy(g => g.LastName).ThenBy(x=>x.FirstName);

                foreach (var emp in result)
                {
                    System.Console.WriteLine($"Name: {emp.LastName} {emp.FirstName}");
                }
            }
        }
    }
}
