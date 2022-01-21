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

            //Created Class Method To Call Object(UC7) && Procedural Way to Compute Monthly Wage For Multiple Companies(UC8)
            Console.WriteLine("Calculating The Monthly Employ wage for multiple companies");
            Console.WriteLine();

            Console.Write("Enter The No. Of Records You Want To Enter Max is 4 : ");
            int records = int.Parse(Console.ReadLine());

            if (records <= 4)
            {
                for (int i = 1; i <= records; i++)
                {
                    Console.Write("Enter The Name Of The Company : ");
                    string company = Console.ReadLine();
                    Console.Write("Enter The Name Of The  Employ : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter The Total Daily Hour : ");
                    int dailyHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter The Wage Per Hour : ");
                    int wagePerHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter The Days in a Month : ");
                    int dayPerMonth = int.Parse(Console.ReadLine());
                    Console.Write("Enter The Total Hours Of That Month You Are Gonna Work : ");
                    int totalHours = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        EmployeeWage.ComputeMonthlyWage(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);                        
                        Console.ReadLine();

                    }
                    if (i == 2)
                    {
                        EmployeeWage.ComputeMonthlyWage(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.ReadLine();

                    }
                    if (i == 3)
                    {
                        EmployeeWage.ComputeMonthlyWage(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.ReadLine();

                    }
                    if (i == 4)
                    {
                        EmployeeWage.ComputeMonthlyWage(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Entries Should be Less than or equal to 4 ");
                Console.ReadLine();
            }
        }
    }
}
