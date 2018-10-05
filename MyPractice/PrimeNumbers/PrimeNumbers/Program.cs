using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeTool = new PrimeTool();
            var number = 100;
            for(var i = 1; i<= number; i++)
            {
                if(primeTool.IsPrimeNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
          
            Console.ReadKey();
        }
       
      
    }
}
