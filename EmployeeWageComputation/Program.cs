using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        public int i = 10;
        static void Main(string[] args)
        {
            //Entered The Welcome Message
            Console.WriteLine("Welcome To The Employee Wage Computation Program");
            Console.ReadLine();

            //Created Class Method To Call Object(UC7) && Procedural Way to Compute Monthly Wage For Multiple Companies(UC8)
            Console.WriteLine("Calculating The Monthly Employ wage for multiple companies");
            Console.WriteLine();
            EmployeeWageBuilder company = new EmployeeWageBuilder();
            company.AddCompanyEmpWageToArray("Dmart",    "Yash",  50, 8,  21, 120);
            company.AddCompanyEmpWageToArray("Reliance", "Ajay",  40, 10, 23, 100);
            company.AddCompanyEmpWageToArray("Microsoft","Aman",  20, 12, 22, 160);
            company.AddCompanyEmpWageToArray("Apple",    "Raj",   45, 20, 20, 180);
            company.AddCompanyEmpWageToArray("Oneplus",  "Omkar", 35, 10, 24, 110);
            company.IterateEmpWageCompany();
            Console.ReadLine();
        }
    }
}
