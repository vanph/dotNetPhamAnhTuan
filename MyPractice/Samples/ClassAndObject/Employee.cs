﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
   public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

       
        public void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} is working");
        }
    }
}
