using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideZeroConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Divide(100, 0);
                //Divide2(200,0);
                Divide3(300, 0);
            }
            catch (Exception e)
            {
                //Todo: Write log here
                Console.WriteLine("Error: " +e.Message);
            }
          
            Console.ReadLine();
        }

        private static void Divide(int x , int y)
        {
            var result = x / y;

            Console.WriteLine(result);

        }


        private static void Divide2(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide zero");
            }
            else
            {
                var result = x / y;

                Console.WriteLine(result);
            }

        }

        private static void Divide3(int x, int y)
        {
            if(y==0)
                throw new ArgumentException($"{nameof(y)} cannot be null");
            var result = x / y;

            Console.WriteLine(result);

        }
    }
}
