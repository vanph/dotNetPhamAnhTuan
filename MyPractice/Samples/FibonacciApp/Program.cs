using System;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            // DisplayAllFiboSeries(number);
            // var fiboValue = CalculateFiboAt(number);
            // Console.WriteLine($"Fibo at {number} is: {fiboValue}");
            //refactor code
            var sum = SumFiboSeries(number);
            Console.WriteLine($"Sum is: {sum}");
            Console.ReadLine();
        }

        private static int SumFiboSeries(int number)
        {
            var fiboSeries = GetFiboSeries(number);
            var sum = fiboSeries.Sum(x => x);
            return sum;
        }

        private static List<int> GetFiboSeries(int number)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for (var index = 2; index < number; index++)
            {
                var previous = fibonacciNumbers[index - 1];
                var previous2 = fibonacciNumbers[index - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            return fibonacciNumbers;
        }

        private static int CalculateFiboAt(int number)
        {
            var fibonacciNumbers = GetFiboSeries(number);

            return fibonacciNumbers[fibonacciNumbers.Count - 1];
        }

        private static void DisplayAllFiboSeries(int number)
        {
            var fibonacciNumbers = GetFiboSeries(number);

            Console.WriteLine($"This is Fibonacci {fibonacciNumbers.Count} numbers:");
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
