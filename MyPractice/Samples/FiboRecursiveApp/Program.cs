using System;
using System.Linq.Expressions;

namespace FiboRecursiveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 20;
            var fiboCalculator = new FiboCalculator();
            var fiboValue = fiboCalculator.CalFiboRecursive(number);
            Console.WriteLine($"Fibo at {number}: {fiboValue}");
            Console.ReadLine();
        }
        
        //static void Main(string[] args)
        //{
        //    const int number = 20;
        //    var fiboValue = CalFiboRecursive(number);
        //    Console.WriteLine($"Fibo at {number}: {fiboValue}");
        //    Console.ReadLine();
        //}

        //private static int CalFiboRecursive(int number)
        //{
        //    if (number <= 0) return 0;
        //    if (number == 1 || number == 2) return 1;

        //    return CalFiboRecursive(number - 1) + CalFiboRecursive(number - 2);
        //}
    }
}
