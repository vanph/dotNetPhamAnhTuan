using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayValue(100);
           // DisplayValue(null);
            bool abc;
            Console.WriteLine(abc);
            Console.ReadLine();
        }

        static void DisplayValue(int? num)
        {
            if (num.HasValue == true)
            {
                Console.WriteLine("num = " + num);
            }
            else
            {
                Console.WriteLine("num = null");
            }

            // num.Value throws an InvalidOperationException if num.HasValue is false
            try
            {
                Console.WriteLine("value = {0}", num.Value);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
