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
        private const int DAYS_PER_MONTH = 20;
        private const int TOTAL_WORK_HOURS = 100;

        //Initializing Variables
        private static int dailyEmpHrs = 0;
        private static int dailyEmpWage =0;

        static void Main(string[] args)
        {
            //Entered The Welcome Message
            Console.WriteLine("Welcome To The Employee Wage Computation Program");
            Console.ReadLine();

            // local Variable
            int totalWage = 0, day = 0, hours = 0;

            //Calculating Wages Per Month And Added Total Hours Condition(UC5 & UC6)
            Random randCheck = new Random();
            while ( day < DAYS_PER_MONTH && hours <= TOTAL_WORK_HOURS)
            {
                //Check Employ Is Present Or Absent(UC1)          
                int checkAttend = randCheck.Next(1, 3);
                string chkEmp;

                //Solved Using Switch Case(UC4)
                switch (checkAttend)
                {
                    case FULL_TIME_EMP:
                        chkEmp = "Full Time";
                        dailyEmpHrs = FULL_DAY_HOUR;
                        break;
                    case PART_TIME_EMP:
                        chkEmp = "Part Time";
                        dailyEmpHrs = HALF_DAY_HOUR;
                        break;
                    default:
                        chkEmp = "  Absent  ";
                        dailyEmpHrs = 0;
                        break;
                }

                //Calculate Employ Daily Wage And Part Time Wage (UC2 & UC3)
                dailyEmpWage = WAGE_PER_HOUR * dailyEmpHrs;
                day++;
                hours += dailyEmpHrs;
                totalWage += dailyEmpWage;
                Console.WriteLine("Day: {0} CheckEmployee: {1} Hours: {2} DailyWage: {3}  TotalWage: {4}", day, chkEmp, hours, dailyEmpWage, totalWage);
            }
            Console.WriteLine("\nEmploy Total Wage Per Month is : " +totalWage);
            Console.ReadLine();
        }
    }
}
