using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            Swap<int>(ref a, ref b);

            Console.WriteLine($"Result: a={a} and b={b}");


            long c = 1000;
            long d = 2000;

            Swap<long>(ref c, ref d);

            Console.WriteLine($"Result: c={c} and d={d}");

            var str1 = "van";
            var str2 = "tuan";

            Swap<string>(ref str1, ref str2);

            Console.WriteLine($"Result: str1={str1} and str2={str2}");

            Console.ReadLine();
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            var temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
