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



        public decimal GetTotalAmountAwardedForAllEmployees()
        {
            decimal totalAmount = 0m;
            Employee emp = default;

            foreach (var employee in _employees)
            {
                totalAmount += employee.EasterBonusAmount;
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
