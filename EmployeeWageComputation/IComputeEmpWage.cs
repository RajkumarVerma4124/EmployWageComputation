using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    { 
         void AddCompanyEmpWageToList(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours);
         void IterateEmpWageCompany();
         void ShowDailyAndTotalWage(string companyName);
        int GetCompanyTotalWage(string companyName);
    }
}
