using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class PayrollController : IPayrollController
    {
        private readonly Payroll _payroll;
        private readonly PayrollConsoleReader _payrollConsoleReader;

        public PayrollController(Payroll payroll, PayrollConsoleReader payrollConsoleReader)
        {
            _payroll = payroll;
            _payrollConsoleReader = payrollConsoleReader;
        }

        public void AddEmployees()
        {
            _payroll.AddEmployees(_payrollConsoleReader.GetEmployees());
        }

        public void TotalCountOfEmployees()
        {
            // Total count of employees entered
            _payroll.GetEmployeeCount();
        }

        public void TotalAmountAwardedForAllEmployees()
        {
            // Total bonus amount awarded for all employees entered
            _payroll.GetTotalAmountAwardedForAllEmployees();
        }

        public void AverageBonusAmountForAllEmployees()
        { // Average bonus amount for all employees
            _payroll.GetAverageBonusAmountForAllEmployees();
        }
    }
}
