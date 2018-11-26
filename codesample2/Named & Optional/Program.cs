using System;

namespace NamedAndOptional
{
    // This program demonstrates how to declare a method with named
    // and optional parameters, and how to call the method while
    // making explicit use of the named and optional parameters.
    internal class Program
    {
        // A method with nameed and optional parameters
        public static void Search(string name, int age = 20, string city = "HN")
        {
            Console.WriteLine("Name = {0} - Age = {1} - City = {2}", name, age, city);
        }

        static void Main(string[] args)
        {
            // Standard call
            Search(name:"Sue", age:22, city:"New York");

            // Standard call
            Search("Sue", 22, "New York");

            Search("Sue", 22);

            Search("Van");

            // Explicitly name the city parameter
            Search("Anh Tuan", city:"Sai Gon");

            // Explicitly name the age parameter
            Search("Anh Tuan", age: 40);

            Console.ReadLine();
        }
    }
}
