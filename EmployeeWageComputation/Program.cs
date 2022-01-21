using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entered The Welcome Message
            Console.WriteLine("Welcome To The Employee Wage Computation Program");
            Console.ReadLine();

            //Created Class Method To Call Object(UC7)
            Console.WriteLine("\nEmploy Total Wage Per Month Is : "+EmployeeWage.ComputeMonthlyWage());
            Console.ReadLine();
        }
    }
}
