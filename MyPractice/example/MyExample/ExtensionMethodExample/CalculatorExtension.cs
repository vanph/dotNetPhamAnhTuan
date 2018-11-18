using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
   public static class CalculatorExtension
    {
        public static int AddMore(this int sourceNumber, int additionNumber)
        {
            return sourceNumber + additionNumber;
        }
    }
}
