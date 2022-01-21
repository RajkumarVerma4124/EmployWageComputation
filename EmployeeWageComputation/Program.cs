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
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.ReadLine();
            }
        }
    }
}
