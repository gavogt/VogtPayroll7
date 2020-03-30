using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class Employee
    {
        private string _empName;

        public int YearsOfService { get; set; }
        public decimal EasterBonusAmount { get; set; }

        public Employee(string empName, int yearsOfService)
        {
            _empName = empName;
            YearsOfService = yearsOfService;

            if (YearsOfService >= 1 && YearsOfService <= 4)
            {
                EasterBonusAmount = 100m;
            }
            else if (YearsOfService >= 4 && YearsOfService <= 9)
            {
                EasterBonusAmount = 500m;
            }
            else if (YearsOfService >= 10)
            {
                EasterBonusAmount = 1000m;
            }
        }
    }
}
