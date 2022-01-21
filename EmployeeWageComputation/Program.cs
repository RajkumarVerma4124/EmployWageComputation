using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        //Initializing Constant
        private const int FULL_TIME_EMP = 1;
        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOUR = 8;

        //Initializing Variables
        private static int dailyEmpHrs = 0;
        private static int dailyEmpWage =0;

        static void Main(string[] args)
        {
            //Entered the welcome message
            Console.WriteLine("Welcome To The Employee Wage Computation Program");
            Console.ReadLine();

            //Check Employ Is Present Or Absent(UC1)          
            Random randCheck = new Random();
            int checkAttend = randCheck.Next(1, 3);
            if (checkAttend == FULL_TIME_EMP)
            {
                Console.WriteLine("Employee is present");
                dailyEmpHrs = FULL_DAY_HOUR;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is absent");
                dailyEmpHrs = 0;
                Console.ReadLine();
            }

            //Calculate Employ Daily Wage (UC2)
            dailyEmpWage = WAGE_PER_HOUR * dailyEmpHrs;
            Console.WriteLine("Employ Todays Wage is :"+dailyEmpWage);
            Console.ReadLine();
        }
    }
}
