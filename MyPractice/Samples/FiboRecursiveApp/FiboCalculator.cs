using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboRecursiveApp
{
    class FiboCalculator
    {
        public int CalFiboRecursive(int number)
        {
            if (number <= 0) return 0;
            if (number == 1 || number == 2) return 1;

            return CalFiboRecursive(number - 1) + CalFiboRecursive(number - 2);
        }
    }
}
