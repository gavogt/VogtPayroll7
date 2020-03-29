using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class Payroll
    {
        private List<Employee> _employees = new List<Employee>();

        public void AddEmployees(List<Employee> empList)
        {
            _employees.AddRange(empList);
        }

        public int GetEmployeeCount()
        {
            Console.WriteLine($"Employee count is: {_employees.Count}");
            return _employees.Count;
        }

        public void GetBonusAmount()
        {
            foreach (var employee in _employees)
            {
                if (employee.YearsOfService >= 1 && employee.YearsOfService <= 4)
                {
                    employee.BonusAmount = 100m;
                }
                else if (employee.YearsOfService >= 4 && employee.YearsOfService <= 9)
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
            decimal totalAmount = 0m;

            GetBonusAmount();

            foreach (var employee in _employees)
            {
                totalAmount += employee.BonusAmount;
            }

            Console.WriteLine($"Total amount awarded: {totalAmount:C2}");

            return totalAmount;
        }

        public void GetAverageBonusAmountForAllEmployees()
        {
            
            Console.WriteLine($"Average bonus amount: {GetTotalAmountAwardedForAllEmployees() / GetEmployeeCount():C2}");
        }
    }
}
