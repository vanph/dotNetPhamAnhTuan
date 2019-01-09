using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            
            //WhereExample(numbers);

           // OrderExample1(numbers);

            //OrderExample2();
            
            //OrderExample3();

            var length = numbers.Length;

            for (int i = 0; i < length-1; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        private static void OrderExample3()
        {
            var employees = new List<Employee>
            {
                new Employee() {FirstName = "Van", LastName = "Pham", Address = "Thai Nguyen", Gender = "Men"},
                new Employee() {FirstName = "Tuan Anh", LastName = "Pham", Address = "Nam Dinh", Gender = "Men"},
                new Employee() {FirstName = "Hieu", LastName = "Nguyen", Address = "Thai Nguyen", Age = 32, Gender = "Men"},
                new Employee() {FirstName = "Duc Anh", LastName = "Hoang", Address = "Ninh Binh", Age = 33, Gender = "Men"},
                new Employee() {FirstName = "Son", LastName = "Nguyen", Address = "Thai Nguyen", Age = 34, Gender = "Men"},
                new Employee() {FirstName = "Le", LastName = "Phan", Address = "Nam Dinh", Age = 35, Gender = "Men"},
                new Employee() {FirstName = "Hoang", LastName = "Nguyen", Address = "Thai Nguyen", Age = 36, Gender = "Men"},
                new Employee() {FirstName = "Dieu Anh", LastName = "Nguyen", Address = "Ninh Binh", Age = 37, Gender = "Women"},
                new Employee() {FirstName = "Kien", LastName = "Dinh", Address = "Thai Nguyen", Age = 38, Gender = "Men"},
                new Employee() {FirstName = "Linh 1", LastName = "Hoang", Address = "Nam Dinh", Age = 39, Gender = "Women"},
                new Employee()
                {
                    FirstName = "Dieu Anh 2",
                    LastName = "Nguyen",
                    Address = "Ninh Binh",
                    Age = 37,
                    Gender = "Women"
                },
                new Employee() {FirstName = "Kien 2", LastName = "Dinh", Address = "Thai Nguyen", Age = 38, Gender = "Men"},
                new Employee() {FirstName = "Linh 2", LastName = "Hoang", Address = "Nam Dinh", Age = 39, Gender = "Women"}
            };

            var orderedEmployees = employees.Where(a => a.Age > 35).OrderBy(x => x.Age).ThenByDescending(x => x.FirstName);

            foreach (var emp in orderedEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }

        private static void OrderExample2()
        {
            string[] words = {"cherry", "apple", "blueberry"};

            var sortedWords = words.OrderBy(w => w);

            Console.WriteLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
        }

        private static void OrderExample1(int[] numbers)
        {
            var orderedNumbers = numbers.OrderByDescending(x => x);

            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
        }

        private static void WhereExample(int[] numbers)
        {
            //var lowNums = from n in numbers where n < 5 select n;

            //var lowNums = numbers.Where(GetNumberLessThanFive);

            var lowNums = numbers.Where(n => n < 5);

            Console.WriteLine("Numbers < 5:");

            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }

        //private static bool GetNumberLessThanFive(int n)
        //{
        //    if (n < 5)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
