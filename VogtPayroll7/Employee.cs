using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class Employee
    {
        private string _empName;

        public int YearsOfService { get; set; }
        public decimal BonusAmount { get; set; }

        public Employee(string empName, int yearsOfService)
        {
            _empName = empName;
            YearsOfService = yearsOfService;

        }



    }
}
