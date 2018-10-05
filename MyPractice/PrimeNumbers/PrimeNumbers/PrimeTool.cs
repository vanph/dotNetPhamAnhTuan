using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeTool
    {
        public bool IsPrimeNumber(int givenNumber)
        {
            if (givenNumber <= 1)
            {
                return false;
            }

            for (var i = 2; i < givenNumber; i++)
            {
                if (givenNumber % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
