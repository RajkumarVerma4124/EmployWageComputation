using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            //Entered The Welcome Message
            Console.WriteLine("Welcome To The Employee Wage Computation Program");
            Console.ReadLine();

            //Created Class Method To Call Object(UC7) && Procedural Way to Compute Monthly Wage For Multiple Companies(UC8)
            Console.WriteLine("Calculating The Monthly Employ wage for multiple companies");
            Console.WriteLine();
            EmployeeWageBuilder company = new EmployeeWageBuilder();
            company.AddCompanyEmpWageToList("Dmart",    "Yash",  25, 8,  21, 120);
            company.AddCompanyEmpWageToList("Reliance", "Ajay",  20, 10, 23, 100);
            company.AddCompanyEmpWageToList("Microsoft","Aman",  10, 12, 22, 160);
            company.AddCompanyEmpWageToList("Apple",    "Raj",   25, 20, 20, 180);
            company.AddCompanyEmpWageToList("Oneplus",  "Omkar", 30, 10, 24, 110);
            company.IterateEmpWageCompany();

            do
            {
                Console.Write("Enter a company name to find there daily wage along with total wage : ");
                string companyName = Console.ReadLine();
                company.ShowDailyAndTotalWage(companyName);
                i++;
                Console.ReadLine();
            }
            while (i < 5);
            
        }
    }
}
