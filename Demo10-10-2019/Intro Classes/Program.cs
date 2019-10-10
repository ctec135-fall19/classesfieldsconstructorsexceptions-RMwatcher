using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object
            // Employee() default constructor from Empolyee.cs
            Employee employee = new Employee();

            // method call
            employee.Hello();
        }
    }
}
