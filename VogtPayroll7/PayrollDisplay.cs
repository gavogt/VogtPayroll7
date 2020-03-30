using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class PayrollDisplay
    {
        private readonly PayrollController _payrollController;

        public PayrollDisplay(PayrollController payrollController)
        {
            _payrollController = payrollController;

        }

        #region PrintMenu
        /// <summary>
        /// Prints the main menu
        /// </summary>
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
                        _payrollController.AddEmployees();
                        break;
                    case 'c':
                        // Total count of employees entered
                        _payrollController.TotalCountOfEmployees();
                        break;
                    case 'b':
                        // Total bonus amount awarded for all employees entered
                        _payrollController.TotalAmountAwardedForAllEmployees();
                        break;
                    case 'e':
                        // Average bonus amount for all employees
                        _payrollController.AverageBonusAmountForAllEmployees();
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
        #endregion

        #region PrintMenuOptions
        /// <summary>
        /// Prints out the menu options
        /// </summary>
        public void PrintMenuOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Please select 'a' to add employees");
            Console.WriteLine("Please select 'c' to get a count of employees");
            Console.WriteLine("Please select 'b' to get the total bonus amount for all employees");
            Console.WriteLine("Please select 'e' to get the average bonus amount for all employees");
            Console.WriteLine("Please select 'q' to quit");

        }
        #endregion

    }
}
