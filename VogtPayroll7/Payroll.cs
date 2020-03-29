using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class Payroll
    {
        private List<Employee> _employees = new List<Employee>();
        private decimal totalAmount = 0m;

        public void AddEmployees(List<Employee> empList)
        {
            _employees.AddRange(empList);
        }

        public void GetEmployeeCount()
        {
            Console.WriteLine($"Employee count is: {_employees.Count}");
        }

        public void GetBonusAmount(int bonusYears)
        {
            foreach (var employee in _employees)
            {
                if (employee.YearsOfService >= 1 || employee.YearsOfService <= 4)
                {
                    employee.BonusAmount = 100m;
                }
                else if (employee.YearsOfService >= 4 || employee.YearsOfService <= 9)
                {
                    employee.BonusAmount = 500m;
                }
                else if(employee.YearsOfService >= 10)
                {
                    employee.BonusAmount = 1000m;
                }
                else
                {
                    Console.WriteLine("Years need to be greater than equal to one!");
                }
            }
        }

        public decimal GetTotalAmountAwardedForAllEmployees()
        {
            foreach (var employee in _employees)
            {
                totalAmount += employee.BonusAmount;
            }

            Console.WriteLine($"Total amount awarded: {totalAmount:C2}");

            return totalAmount;
        }

        public void GetAverageBonusAmountForAllEmployees()
        {
            Console.WriteLine($"Average bonus amount: {GetTotalAmountAwardedForAllEmployees() % 2:C2}");
        }
    }
}
