using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Val_vs_Ref_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = a;
            //a = a * 2;
            //Swap(a, b);
            //Console.WriteLine($"a = {a} and b = {b}");//a= 20, b=10

            //Swap2(ref a, ref b);
            //Console.WriteLine($"Second: a = {a} and b = {b}"); //a=10; b=20

            //Swap3( a, ref b);
            //Console.WriteLine($"Third: a = {a} and b = {b}"); //a= 10, b=10

            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(default(int));

            ////int 2 bytes => 16 bit : 0,1
            ////2^16
            ////Console.WriteLine(Math.Pow(2,32) );

            //Console.WriteLine(long.MaxValue);
            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(default(long));

            //string a = "hello";
            //string b = "h";
            //// Append to contents of 'b'  
            //b += "ello";
            //Console.WriteLine(a == b);
            //Console.WriteLine((object)a == (object)b);

            string str1 = "tuan";
            string str2 = str1;
            str2 = "van";
            //str1 =?

            Console.WriteLine(str1);

            TestAnonymousType();

            //LINQ
            var numbers = new int[] { 2, 100, 4, 6, 79, 8 };
            //var orderedNumbers = numbers.OrderByDescending(x => x);
            //foreach(var i in orderedNumbers)
            //{
            //    Console.WriteLine(i);
            //}
            // Order array numbers - Sap xep tang dan
            int lengthOfNumbers = numbers.Length;
            for (int i = 0; i < lengthOfNumbers-2; i++)
            {
                if (numbers[i] > numbers[i+1])
                {
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = numbers[i];
                }
            }
            Console.WriteLine(numbers);
            Console.ReadKey();
        }

       private static void TestAnonymousType()
       {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following  
            // statement to verify that their inferred types are int and string.  
            Console.WriteLine(v.Amount + v.Message);
       }

        private static void Swap(int a, int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private static void Swap2( ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        private static void Swap3( int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
