using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll7
{
    class PayrollConsoleReader
    {
        public Employee GetEmployee()
        {
            Console.WriteLine();

            Console.Write("Please enter employee name: ");
            var empName = Console.ReadLine();

            Console.WriteLine("Please enter years of service: ");
            var yearsOfService = Convert.ToInt32(Console.ReadLine());

            return new Employee(empName, yearsOfService);

        }

        public List<Employee> GetEmployees()
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            int howMany;
            List<Employee> empList = new List<Employee>();

            do
            {
                Console.WriteLine("How many employees would you like to add?");
                howMany = Convert.ToInt32(Console.ReadLine());
            } while (howMany < 0 || howMany > 10);

            for (int i = 0; i < howMany; i++)
            {
                Employee emp = payrollConsoleReader.GetEmployee();

                empList.Add(emp);
            }

            return empList;
        }
    }
}
