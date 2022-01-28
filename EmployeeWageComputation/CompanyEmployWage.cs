using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmployWage
    {
        //Declaring Variables
        public readonly string company;
        public readonly int dailyWage;
        public readonly int totalWage;
        public readonly string name;
        public readonly int wagePerHours;
        public readonly int dailyHours;
        public readonly int dayPerMonth;
        public readonly int totalHours;
        public int totalEmpWage;

        //To store daily Wage along with total Wage list(UC13)
        public CompanyEmployWage(string company, int dailyWage, int totalWage)
        {
            this.company = company;
            this.dailyWage = dailyWage;
            this.totalWage = totalWage;
        }

        public CompanyEmployWage(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            this.company = company;
            this.name = name;
            this.wagePerHours = wagePerHours;
            this.totalHours = totalHours;
            this.dailyHours = dailyHours;
            this.dayPerMonth = dayPerMonth;
            this.totalHours = totalHours;
        }

        //Saving total wage for each company(UC9)
        public void SetTotalEmployWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        //Returning company name with total wage of the company
        public string CompanyTotalWageToString()
        {
            return "Company Name : "+this.company+" \nMonthly Wage Is Rs : "+this.totalEmpWage;
        }

    }
}
