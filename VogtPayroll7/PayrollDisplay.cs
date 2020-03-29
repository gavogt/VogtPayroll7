using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class PayrollDisplay
    {
        private readonly PayrollConsoleReader _payrollConsoleReader;
        private readonly Payroll _payroll;

        public PayrollDisplay(PayrollConsoleReader payrollConsoleReader, Payroll payroll)
        {
            _payrollConsoleReader = payrollConsoleReader;
            _payroll = payroll;
        }

        public void PrintMenu()
        {
            char option;

            PrintMenuOptions();

            do
            {
                Console.WriteLine("\nAwaiting input");
                option = Convert.ToChar(Console.ReadLine().ToLower());
                switch (option)
                {
                    case 'a':
                        _payroll.AddEmployees(_payrollConsoleReader.GetEmployees());
                        break;
                    case 'c':
                        // Total count of employees entered
                        _payroll.GetEmployeeCount();
                        break;
                    case 'b':
                        // Total bonus amount awarded for all employees entered
                        _payroll.GetTotalAmountAwardedForAllEmployees();
                        break;
                    case 'e':
                        // Average bonus amount for all employees
                        _payroll.GetAverageBonusAmountForAllEmployees();
                        break;
                    case 'q':
                        // Don't do anything
                        break;
                    default:
                        Console.WriteLine("Please select 'a', 'c', 'b', 'e' or 'q'");
                        break;
                }

            } while (option != 'q');
        }

        public void PrintMenuOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Please select 'a' to add employees");
            Console.WriteLine("Please select 'c' to get a count of employees");
            Console.WriteLine("Please select 'b' to get the total bonus amount for all employees");
            Console.WriteLine("Please select 'e' to get the average bonus amount for all employees");
            Console.WriteLine("Please select 'q' to quit");
        }

    }
}
