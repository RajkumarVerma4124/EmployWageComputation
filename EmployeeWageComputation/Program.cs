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
        private const int PART_TIME_EMP = 2;
        private const int WAGE_PER_HOUR = 20;
        private const int FULL_DAY_HOUR = 8;
        private const int HALF_DAY_HOUR = 4;

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
            int checkAttend = randCheck.Next(0, 3);

            //Solved Using Switch Case(UC4)
            switch(checkAttend)
            {
                case FULL_TIME_EMP:
                    Console.WriteLine("Employee is present for full time");
                    dailyEmpHrs = FULL_DAY_HOUR;
                    Console.ReadLine();
                    break;
                case PART_TIME_EMP:
                    Console.WriteLine("Employee is present for part time");
                    dailyEmpHrs = HALF_DAY_HOUR;
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Employee is absent for today");
                    dailyEmpHrs = 0;
                    Console.ReadLine();
                    break;
            }

            //Calculate Employ Daily Wage And Part Time Wage (UC2 & UC3)
            dailyEmpWage = WAGE_PER_HOUR * dailyEmpHrs;
            Console.WriteLine("Employ Todays Wage is : " +
                "" +
                ""+dailyEmpWage);
            Console.ReadLine();
        }
    }
}
