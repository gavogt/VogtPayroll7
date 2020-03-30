using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class Payroll
    {
        private List<Employee> _employees = new List<Employee>();

        #region AddEmployees
        /// <summary>
        /// Adds employees to a private list from a list
        /// </summary>
        /// <param name="empList">List to pass in</param>
        public void AddEmployees(List<Employee> empList)
        {
            _employees.AddRange(empList);

        }
        #endregion

        #region GetEmployeeCount
        /// <summary>
        /// Gets the count of how many employees
        /// </summary>
        /// <returns>How many employees</returns>
        public int GetEmployeeCount()
        {
            Console.WriteLine($"Employee count is: {_employees.Count}");

            return _employees.Count;

        }
        #endregion

        #region GetTotalAmountAwardedForAllEmployees
        /// <summary>
        /// Gets the total amount for all employees
        /// </summary>
        /// <returns>The total amount rewarded</returns>
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
        #endregion

        #region GetAverageBonusAmountForAllEmployees
        /// <summary>
        /// Get the average bonus for all employees
        /// </summary>
        public void GetAverageBonusAmountForAllEmployees()
        {
            
            Console.WriteLine($"Average bonus amount: {GetTotalAmountAwardedForAllEmployees() / GetEmployeeCount():C2}");
        }
        #endregion

    }
}
