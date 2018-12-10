using System;
using System.Linq;
using Delegates2.CustomDelegate;

namespace Delegates2
{
    internal class Program
    {
        public static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
        }

        public static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
        }

        public static void Main()
        {
            MyDelegate a, b;

            // Create the delegate object a that references 
            // the method Hello:
            //a = new MyDelegate(Hello);
            //Or:
            a = Hello; 

            // Create the delegate object b that references 
            // the method Goodbye:
            b = new MyDelegate(Goodbye);
            //Or:
            //b = Goodbye;

            // The two delegates, a and b, are composed to form c, 
            // which calls both methods in order:
            var c = a + b;

            //// Remove a from the composed delegate, leaving d, 
            //// which calls only the method Goodbye:
            var d = c - a;

            //Console.WriteLine("Invoking delegate a:");
            //a("Van");
            //Console.WriteLine("Invoking delegate b:");
            //b("Anh Tuan");
            //Console.WriteLine("Invoking delegate c:");
            //c("Hieu");
            //Console.WriteLine("Invoking delegate d:");
            //d("D");

            var numbers = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 90,101};

            foreach (var item in numbers)
            {
                if (IsEven(item))
                {
                    Console.WriteLine(item);
                }
            }

            //var evenNumbers1 = numbers.Where(x => IsEven(x));
            //var evenNumbers2 = numbers.Where(IsEven);
            Console.WriteLine("Test LINQ");
            var evenNumbers = numbers.Where(x => x % 2 ==0);
            foreach (var i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Test LINQ2");
            var myNumbers = numbers.Where(e => (e % 2 == 0 && e%3 !=0));
            foreach (var i in myNumbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

       static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}