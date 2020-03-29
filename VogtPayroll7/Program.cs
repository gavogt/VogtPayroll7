﻿using System;

namespace VogtPayroll7
{
    class Program
    {
        static void Main(string[] args)
        {
             Run(new PayrollDisplay(new PayrollConsoleReader(), new Payroll()));
        }

        public static void Run(PayrollDisplay payrollDisplay)
        {
            payrollDisplay.PrintMenu();
            Console.Clear();
            Console.WriteLine("Exiting...");
            Environment.Exit(0);

        }
    }
}
