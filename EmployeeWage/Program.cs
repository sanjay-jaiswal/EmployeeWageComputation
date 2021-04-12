using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");
            ComputeEmployeeWage.computeEmpWage("DMart", 20, 2, 10);
            ComputeEmployeeWage.computeEmpWage("Reliance", 10, 4, 20);
            ComputeEmployeeWage.computeEmpWage("PhonePay", 15, 5, 22);
        }       
    }
}