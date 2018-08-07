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
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"Tong cac so chia het cho 3 hoac 5 nho hon 1000 la: {sum}");
            
            //C2
            int sum2 = 0;
            int i2 = 0;
            while (i2 < 1000)
            {
                if (i2 % 3 == 0 || i2 % 5 == 0)
                {
                    sum2 = sum2 + i2;
                }
                i2++;
            }
            Console.WriteLine($"Tong cac so chia het cho 3 hoac 5 nho hon 1000 la: {sum2}");

            //C3
            int sum3 = 0;
            int i3 = 0;
            do
            {
                if (i3 % 3 == 0 || i3 % 5 == 0)
                {
                    sum3 = sum3 + i3;
                }
                i3++;
            } while (i3 < 1000);
            Console.WriteLine($"Tong cac so chia het cho 3 hoac 5 nho hon 1000 la: {sum3}");
        }
    }
}
