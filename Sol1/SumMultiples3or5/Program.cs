using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMultiples3or5
{
    class Program
    {
        static void Main(string[] args) 
        {

            //C1
            Console.Write("Please input a number:");
            var inputNumberString = Console.ReadLine();
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

            //v1: using int.Parse method to convert a string to int
            //try
            //{
            //    var number = int.Parse(inputNumberString);
            //    int sum = SumOfMultiplesThreeOrFiveLessThanGivenNumber(number);

            //    Console.WriteLine($"Tong cac so chia het cho 3 hoac 5 nho hon {number} la: {sum}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            

            //v2: using int.TryParse method to convert a string to int
            int number;
            bool success = int.TryParse(inputNumberString, out number);
            if(success)
            {
                int sum = SumOfMultiplesThreeOrFiveLessThanGivenNumber(number);

                Console.WriteLine($"Tong cac so chia het cho 3 hoac 5 nho hon {number} la: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input number.");
            }


            Console.ReadKey();
        }

        private static int SumOfMultiplesThreeOrFiveLessThanGivenNumber(int number)
        {
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}
