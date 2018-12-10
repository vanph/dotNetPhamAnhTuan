using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
   public class MediaTester
    {
        public void RunTest(MediaFunction function)
        {
            int result = function();

            if (result == 0)
            {
                Console.WriteLine("Works!");
            }
            else
            {
                Console.WriteLine("Failed.");
            }

        }
    }
}
