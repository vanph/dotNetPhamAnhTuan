using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            var inputNumberString = Console.ReadLine();

            try
            {
                var number = int.Parse(inputNumberString);

                for (int j = 1; j <= number; j++)
                {
                    Console.WriteLine($"# {j}");
                }
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
