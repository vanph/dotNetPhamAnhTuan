﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            emp.FirstName = "Van";
            emp.LastName = "Pham";
            Console.WriteLine(emp.FirstName);
            
            Console.WriteLine(Common.UsaMoneySymbol);
            Console.WriteLine(Common.VnMoneySymbol);

            Console.WriteLine(Common.Message);
            Common.Message = "abc";

            Console.WriteLine(Common.Message);
            Console.ReadLine();
        }
    }
}
