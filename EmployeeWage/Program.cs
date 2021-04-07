using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Welome to Employee Wage Program***********");
            //Constants
            int PRESENT = 1;

            Random random = new Random();
            int employeeCheck = random.Next(0, 2);

            Console.WriteLine("random value " + employeeCheck);
            if (employeeCheck == PRESENT)
            {
                Console.WriteLine("Employee is Present.");

            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
            Console.ReadLine();
        }
    }
}