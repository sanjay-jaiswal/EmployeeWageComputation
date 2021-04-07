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
            int EMP_RATE_PER_HOUR = 20;
            //local variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);

            Console.WriteLine("random value " + employeeCheck);
            if (employeeCheck == PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee wage per day is : " + empWage);
            Console.ReadLine();
        }
    }
}